using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;

// Output the build size or a failure depending on BuildPlayer.

public class BuildPlayer
{
    [MenuItem("Build/Build Android")]
    public static void BuildAndroid()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        //buildPlayerOptions.scenes = new[] { "Assets/videoInput.unity" };     
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/Main.unity" };
        buildPlayerOptions.locationPathName = "AndroidBuild.apk";
        buildPlayerOptions.target = BuildTarget.Android;

        PlayerSettings.bundleVersion = "0.1." + System.DateTime.Now.ToString("yyyyMMddHHmmss");
        PlayerSettings.Android.bundleVersionCode = 2;// + System.DateTime.Now.ToString("yyyyMMddHHmmss");
        PlayerSettings.Android.useCustomKeystore = false;
        buildPlayerOptions.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }

}