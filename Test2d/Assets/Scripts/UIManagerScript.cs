using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	public void StartStage1()
	{
		Application.LoadLevel("Scene1");
	}
	public void StartStage2Debug()
	{
		Application.LoadLevel("Stage1");
	}

	public void ExitGame()
	{
		Application.Quit();
	}
	public void StartMainMenu()
	{
		Application.LoadLevel("MainMenu");
	}
}
