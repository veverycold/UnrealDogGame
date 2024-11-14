// Dog Game. Copyright VeveryCold. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class DogGameEditorTarget : TargetRules
{
	public DogGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange( new string[] { "DogGame" } );
	}
}
