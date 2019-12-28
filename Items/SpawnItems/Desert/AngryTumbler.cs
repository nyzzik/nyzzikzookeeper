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
    class AngryTumbler : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Angry Tumbler");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 42;
            item.maxStack = 20;
            item.value = Item.buyPrice(0, 0, 6, 0);
            item.rare = 0;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }
        public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.Center.X - 100, (int)player.Center.Y, 546, 0, 0.0f, 0.0f, 0.0f, byte.MaxValue);
            Main.PlaySound(15, (Vector2)player.position, 0);
            return true;
        }

        
    }
}
