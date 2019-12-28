using Terraria.ModLoader;

namespace nyzzikzookeeper
{
	public class nyzzikzookeeper : Mod
	{
		public nyzzikzookeeper()
		{
        }
        public override void PostSetupContent()
        {
            Mod censusMod = ModLoader.GetMod("Census");
            if (censusMod != null)
            {
                // Here I am using Chat Tags to make my condition even more interesting.
                // If you localize your mod, pass in a localized string instead of just English.
                censusMod.Call("TownNPCCondition", NPCType("Zookeeper"), $"Defeat King Slime");
                // Additional lines for additional town npc that your mod adds
                // Simpler example:
                // censusMod.Call("TownNPCCondition", NPCType("Simple"), "Defeat Duke Fishron");
            }
        }
    }
}