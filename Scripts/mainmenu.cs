using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

	public void Startt()
	{
		SceneManager.LoadScene(1);
	}
	public void Quit()
	{
		Application.Quit();
	}
	public void mainm()
	{
		SceneManager.LoadScene("MainMenu");
	}

}
