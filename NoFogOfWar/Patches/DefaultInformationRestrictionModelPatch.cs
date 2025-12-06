using HarmonyLib;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.CampaignSystem.GameComponents;

namespace NoFogOfWar.Patches
{
    [HarmonyPatch(typeof(DefaultInformationRestrictionModel))]
    class DefaultInformationRestrictionModelPatch
    {
        [HarmonyPrefix]
        [HarmonyPatch("DoesPlayerKnowDetailsOf", new System.Type[] { typeof(Settlement) })]
        public static bool DoesPlayerKnowDetailsOf(ref bool __result)
        {
            if (!Configs.Instance.Settlements)
            {
                return true;
            }

            __result = true;

            return false;
        }
    }
}
