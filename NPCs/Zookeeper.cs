using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace nyzzikzookeeper.NPCs
{
    [AutoloadHead]
    class Zookeeper : ModNPC
    {

        public static int shopChoice = 0;

        public override string Texture => "nyzzikzookeeper/NPCs/Zookeeper";

        public override string[] AltTextures => new[] { "nyzzikzookeeper/NPCs/Zookeeper_Alt_1" };

        public override bool Autoload(ref String name)
        {
            name = "Zookeeper";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 10;
            NPCID.Sets.AttackFrameCount[npc.type] = 5;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = .5f;
            animationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {

            return NPC.downedSlimeKing;
        }
        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(9))
            {
                case 0:
                    return "Daniel";
                case 1:
                    return "Danew";
                case 2:
                    return "Maxwell";
                case 3:
                    return "Sam";
                case 4:
                    return "Levi";
                case 5:
                    return "Andrew";
                case 6:
                    return "James";
                case 7:
                    return "Logan";
                case 8:
                    return "Jake";
                default:
                    return "Paul";
            }
        }


        public override string GetChat()
        {
            switch ((Main.rand).Next(6))
            {
                case 0:
                    return "There are many more of us zookeepers, I wonder if the others will also move in.";
                case 1:
                    return "These bunny are breeding like, well, bunnys!";
                case 2:
                    return "I'm not very sociable...";
                case 3:
                    return "You better be careful with my pets, they mean a lot to me";
                case 4:
                    return "I probably talk to my animals more than anyone else...";
                default:
                    return "I need more quotes";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            if (shopChoice == 4)
            {
                shopChoice = 0;
            }

            if (shopChoice == 0)
            {
                button = "Critters";
            }
            if (shopChoice == 1)
            {
                button = "Forest";
            }
            if (shopChoice == 2)
            {
                button = "Desert";
            }
            if (shopChoice == 3){
                button = "Snow";
            }

            button2 = "Change Shop";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                
                shop = true;
            }
            else
            {
                shopChoice++;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            if(shopChoice==0)
            {
                ((Item)shop.item[nextSlot]).SetDefaults(2740, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2018, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(3563, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2015, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(1994, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2019, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2016, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2017, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2123, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2122, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(1998, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(1992, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2002, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2000, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(1997, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2001, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(1996, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(1995, false);
                ++nextSlot;
                if (!NPC.downedMechBossAny)
                    return;
                ((Item)shop.item[nextSlot]).SetDefaults(2890, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(3564, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2889, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(1999, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2891, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2893, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2895, false);
                ++nextSlot;
            }
            else if (shopChoice == 1)
            {
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("GreenSlime"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("PurpleSlime"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("BlueSlime"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Raven"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SlimedZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmedSlimedZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Zombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmedZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ZombieChristmasVariant1"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ZombieChristmasVariant2"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("BaldZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("PincushionZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmedPincushionZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("FemaleZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmedFemaleZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("TwiggyZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmedTwiggyZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("DemonEye"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("GreenEye"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("PurpleEye"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("CataractEye"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("DilatedEye"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SleepyEye"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SwampZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmedSwampZombie"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ZombieHalloweenVariant1"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("DemonEyeHalloweenVariant1"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("DemonEyeHalloweenVariant2"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ZombieHalloweenVariant2"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ZombieHalloweenVariant3"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("GoblinScout"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Pinky"), false);
                ++nextSlot;
                if (!NPC.downedMechBossAny)
                    return;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("PossessedArmor"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Wraith"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("WanderingEye"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("HoppinJack"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Werewolf"), false);
                ++nextSlot;
            }
            else if(shopChoice == 2)
            {
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Antlion"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Vulture"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SandSlime"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("AntlionCharger"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("AntlionSwarmer"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("TombCrawler"), false);
                ++nextSlot;
                if (NPC.downedBoss1)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("AngryTumbler"), false);
                    ++nextSlot;
                }
                if (NPC.downedMechBossAny)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Ghoul"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Mummy"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Lamia"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Lamia2"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SandPoacher"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("VileGhoul"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("TaintedGhoul"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("DarkMummy"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("LightMummy"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("DuneSplicer"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("DreamerGhoul"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Basilisk"), false);
                    ++nextSlot;
                }
                if (NPC.killCount[Item.NPCtoBanner(NPCID.SandElemental)] != 0)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SandShark"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("BoneBiter"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("FleshReaver"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("CrystalThresher"), false);
                    ++nextSlot;
                }
                ((Item)shop.item[nextSlot]).SetDefaults(2157, false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(2156, false);
                ++nextSlot;
                if (NPC.killCount[Item.NPCtoBanner(NPCID.SandElemental)] >= 1)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SandElemental"), false);
                    ++nextSlot;
                }
                
            }          
            else if(shopChoice == 3)
            {
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("IceSlime"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("CyanBeetle"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ZombieEskimo"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmedZombieEskimo"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("UndeadViking"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SpikedIceSlime"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SnowFlinx"), false);
                ++nextSlot;
                ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("IceBat"), false);
                ++nextSlot;
                if (NPC.downedFrost)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("MisterStabby"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SnowmanGangsta"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("SnowBalla"), false);
                    ++nextSlot;
                }
                if (NPC.downedMechBossAny)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("IceTortoise"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("ArmoredViking"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("IcyMerman"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("Wolf"), false);
                    ++nextSlot;
                }
                ((Item)shop.item[nextSlot]).SetDefaults(2205, false);
                ++nextSlot;
                if (NPC.downedMechBossAny)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("IceElemental"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("CorruptionPigron"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("HallowPigron"), false);
                    ++nextSlot;
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("CrimsonPigron"), false);
                    ++nextSlot;
                }
                if (NPC.killCount[Item.NPCtoBanner(NPCID.IceGolem)] >= 1)
                {
                    ((Item)shop.item[nextSlot]).SetDefaults(mod.ItemType("IceGolem"), false);
                    ++nextSlot;
                }
                    
                
            }
        }

    }
}
