using UnrealBuildTool;

public class FightingGameClientTarget : TargetRules
{
	public FightingGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FightingGame");
	}
}
