using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace NightmaresMod.Items.Weapons.Magic
{
    public class FistofFury : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fist of Fury");
            Tooltip.SetDefault("'Hiyaaa!'");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.useTime = 10;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.value = 120000; //12 gold
            item.rare = 10; //Red
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.scale = 1f;
            item.magic = true; //Item type
            item.mana = 7; //Mana usage
            item.shootSpeed = 12f;
            item.noMelee = true; //Item itself does not deal damage
            item.shoot = mod.ProjectileType("FistofFuryProj");
            item.damage = 48;
            item.noMelee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NimbusRod);
            recipe.AddTile(412);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
