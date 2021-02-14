using StardewValley;
using StardewValley.Tools;

namespace UpgradablePan
{
	public class ItemPatches
	{
		public static bool canBeTrashed_Prefix(ref Item __instance, ref bool __result)
		{
			// Make it so you can't throw pans away.
			if (__instance is Pan)
			{
				__result = false;
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}