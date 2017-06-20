using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class menuScript : MonoBehaviour 
{

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;
	public Button helpText;
	public Canvas helpMenu;
	public string URL1;
	public string URL2;
	public string URL3;



	// Use this for initialization
	void Start () 
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		helpText = helpText.GetComponent<Button> ();
		quitMenu.enabled = false;
		helpMenu.enabled = false;
		
	}

	public void ExitPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false; 
		helpMenu.enabled = false;
		helpText.enabled = false;

	}

	public void NoPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true; 
		helpText.enabled = true;
		helpMenu.enabled = false;

	}

	public void HelpPress()
	{
		quitMenu.enabled = false;
		startText.enabled = false;
		exitText.enabled = false; 
		helpText.enabled = false;
		helpMenu.enabled = true;
	}
		
	public void Startlevel()
	{
		SceneManager.LoadScene("levelSelect");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	public void urlLinkOrWeb() 
	{
		Application.OpenURL(URL1);
	}﻿
		
}
