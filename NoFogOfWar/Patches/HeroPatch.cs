using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace NoFogOfWar
{
    [HarmonyPatch(typeof(Hero))]
    public static class HeroPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("IsKnownToPlayer", MethodType.Getter)]
        public static bool IsKnownToPlayer(ref bool __result)
        {
            if (!Configs.Instance.Heroes)
            {
                return true;
            }

            __result = true;

            return false;
        }
    }
}