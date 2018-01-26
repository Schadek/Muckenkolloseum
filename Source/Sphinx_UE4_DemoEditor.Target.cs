// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Sphinx_UE4_DemoEditorTarget : TargetRules
{
    public Sphinx_UE4_DemoEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        ExtraModuleNames.AddRange(new string[] { "Sphinx_UE4_Demo" });
    }
}