// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class Sphinx_UE4_Demo : ModuleRules
{
	public Sphinx_UE4_Demo(ReadOnlyTargetRules Target) : base(Target)
    {
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "AIModule", "CoreUObject", "LevelSequence", "Engine", "InputCore", "UMG", "Slate", "SpeechRecognition", "SlateCore", "OnlineSubsystem", "OnlineSubsystemUtils", "Sockets", "GameplayTasks" });
        DynamicallyLoadedModuleNames.AddRange(new string[] { "OnlineSubsystemSteam", "OnlineSubsystemNull" });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
