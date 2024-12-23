using UnrealBuildTool;

public class FightingGameTarget : TargetRules
{
	public FightingGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FightingGame");
	}
}
