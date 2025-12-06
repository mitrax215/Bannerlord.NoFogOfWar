using MCM.Abstractions.Attributes;
using MCM.Abstractions.Base.Global;
using MCM.Abstractions.Attributes.v2;

namespace NoFogOfWar
{
    public class Configs : AttributeGlobalSettings<Configs>
    {
        public override string Id => "NoFogOfWar";

        public override string DisplayName => "No fog of war";

        public override string FolderName => "NoFogOfWar";

        public override string FormatType => "json2";

        private const string HeadingNoFogOfWar = "{=NoFogOfWar.b5527329}No fog of war";

        [SettingPropertyBool(displayName: "{=NoFogOfWar.4f8e20f7}Heroes", Order = 0, RequireRestart = false, HintText = "{=NoFogOfWar.6ffb53b3}It allows the player to get to know all the heroes.")]
        [SettingPropertyGroup(HeadingNoFogOfWar)]
        public bool Heroes { get; set; } = true;

        [SettingPropertyBool(displayName: "{=NoFogOfWar.6d91efcd}Settlements", Order = 1, RequireRestart = false, HintText = "{=NoFogOfWar.42c2da62}It allows the player to explore all the settlements.")]
        [SettingPropertyGroup(HeadingNoFogOfWar)]
        public bool Settlements { get; set; } = true;
    }
}