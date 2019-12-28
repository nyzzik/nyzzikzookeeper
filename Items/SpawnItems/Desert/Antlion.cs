using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace nyzzikzookeeper.Items.SpawnItems.Desert
{
    class Antlion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(nameof(Antlion));
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 62;
            item.maxStack = 0;
            item.value = 300;
            item.rare = 0;
            item.useAnimation = 0;
            item.useTime = 0;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)(player).Center.X - 100, (int)(player).Center.Y, 69, 0, 0.0f, 0.0f, 0.0f, 0.0f, (int)byte.MaxValue);
            Main.PlaySound(15, (Vector2)((Entity)player).position, 0);
            return true;
        }
    }
}
