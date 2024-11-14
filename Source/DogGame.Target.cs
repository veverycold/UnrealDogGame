// Dog Game. Copyright VeveryCold. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class DogGameTarget : TargetRules
{
    public DogGameTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.AddRange(new string[] { "DogGame" });
    }
}
