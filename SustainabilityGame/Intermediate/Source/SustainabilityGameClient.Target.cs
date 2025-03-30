using UnrealBuildTool;

public class SustainabilityGameClientTarget : TargetRules
{
	public SustainabilityGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SustainabilityGame");
	}
}
