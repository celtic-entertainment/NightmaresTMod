using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NightmaresMod.Tiles.Bricks
{
    public class NightmariumBrickTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("NightmariumBrick");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Nightmarium Brick");
            AddMapEntry(new Color(150, 200, 255), name);
            minPick = 145;
            dustType = DustID.Platinum;
            Main.tileLavaDeath[Type] = true;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.25f;
            g = 0f;
            b = 0.32f;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}