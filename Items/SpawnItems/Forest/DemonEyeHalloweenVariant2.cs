﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace nyzzikzookeeper.Items.SpawnItems.Forest
{
    class DemonEyeHalloweenVariant2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("UFO Eye");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            ((Entity)item).width = 38;
            ((Entity)item).height = 30;
            item.maxStack = 20;
            item.value = 500;
            item.rare = 0;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)((Entity)player).Center.X - 100, (int)((Entity)player).Center.Y, 318, 0, 0.0f, 0.0f, 0.0f, 0.0f, (int)byte.MaxValue);
            Main.PlaySound(15, (Vector2)((Entity)player).position, 0);
            return true;
        }
    }
}
