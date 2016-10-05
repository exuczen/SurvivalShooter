﻿#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

/// <summary>Unity extension stuff</summary>
public static class UnityExtension
{
	[MenuItem("Scenes/Main")]
	public static void OpenSceneMain() {
		CT.ExtensionUNITY.OpenScene("Scenes/Level 01");
	}
	[MenuItem("Scenes/Completed")]
	public static void OpenSceneCompleted() {
		CT.ExtensionUNITY.OpenScene("_CompletedAssets/Scenes/Level 01 5.x");
	}

	/// <summary>Shift+C to take a screenshot of game window</summary>
	[MenuItem("Window/Capture Screenshot #p")]
	public static void TakeScreenshot() {
		CT.ExtensionUNITY.Screenshot.Take();
	}
}
#endif