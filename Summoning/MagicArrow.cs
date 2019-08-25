using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresMod.Items.Weapons.Summoning
{
	public class MagicArrow : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("'I'm Mary Poppins, y'all!'");
		}

		public override void SetDefaults() {
			item.damage = 25;
			item.summon = true;
			item.mana = 14;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.noMelee = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.knockBack = 8;
			item.value = Item.sellPrice(silver : 50);
			item.rare = 3;
			item.UseSound = SoundID.Item9;
			item.shoot = mod.ProjectileType("MagicArrowProjectile");
            item.shootSpeed = 10f;
		}

		// This item's mana usage changes through the day, peaking at 1.5x mana usage at noon, and 0.5x mana usage at midnight.
		// Thanks to chikenbones for the help in the calculations
		/*public override void ModifyManaCost(Player player, ref float reduce, ref float mult) {
			double currentTime = Main.time;
			// The time at which it changes from day to night and vice versa.
			double maxTime = Main.dayTime ? Main.dayLength : Main.nightLength;
			// More mana during day, less at night
			int direction = Main.dayTime ? 1 : -1;
			// Sine goes from 0 to 1 to 0 over a period of pi, so we match that to the length of the day/night.
			float timeMult = (float)Math.Sin(currentTime / maxTime * Math.PI);
			// Then we multiply by direction so it goes between 1 and -1 through the entire day, then multiply by 0.5 and add 1 to make it go between 1.5 and 0.5.
			timeMult = 1 + timeMult * direction * 0.5f;
			// Last, we multiply the current mana cost multiplier of the item by our multiplier.
			mult *= timeMult;
		}*/

		public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("NightmariumBar"), 20);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}