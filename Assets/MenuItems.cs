#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.IO;
using System;

public class MenuItems
{
	[MenuItem("Tools/Clear PlayerPrefs")]
	private static void NewMenuOption()
	{
		PlayerPrefs.DeleteAll();
	}

	[MenuItem("Tools/Persistent DataPath")]
	private static void PersistentPath()
	{
		Debug.Log(Application.persistentDataPath);
	}

	[MenuItem("Tools/Restart")]
	private static void RestartLevel()
	{
		Application.LoadLevel(Application.loadedLevel);
	}

	[MenuItem("Tools/RemainingTime")]
	private static void RemainingTime()
	{


		Debug.Log("PlayerPrefs.GetString(\"_timer\") == " + PlayerPrefs.GetString("_timer"));

//		Debug.Log("Remaining Time == " + DailyEventTimer.eventEndTime.Add(TimeSpan.Parse("23:00:00")));
	}
}
#endif