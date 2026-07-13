using UnrealBuildTool;
using System.Collections.Generic;

public class MockUnrealTarget : TargetRules
{
	public MockUnrealTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("MockUnreal");
	}
}
