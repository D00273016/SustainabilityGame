using UnrealBuildTool;

public class SustainabilityGameTarget : TargetRules
{
	public SustainabilityGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SustainabilityGame");
	}
}
