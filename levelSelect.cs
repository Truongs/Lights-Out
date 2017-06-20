using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour 
{
	public Canvas stageOne;
	public Canvas stageTwo;
	public Canvas stageThree;
	public Button menuOne;
	public Button menuTwo;
	public Button menuThree;
	public Button exitOne;
	public Button exitTwo;
	public Button exitThree;
	public Button yesOne;
	public Button yesTwo;
	public Button yesThree;
	public Button back;


	void Start() 
	{
		stageOne.enabled = false;
		stageTwo.enabled = false;
		stageThree.enabled = false;
		stageOne = stageOne.GetComponent<Canvas> ();
		stageTwo = stageTwo.GetComponent<Canvas> ();
		stageThree = stageThree.GetComponent<Canvas> ();
		menuOne = menuOne.GetComponent<Button> ();
		menuTwo = menuOne.GetComponent<Button> ();
		menuThree = menuOne.GetComponent<Button> ();
		exitOne = exitOne.GetComponent<Button> ();
		yesOne = yesOne.GetComponent<Button> ();
		yesTwo = yesTwo.GetComponent<Button> ();
		yesThree = yesThree.GetComponent<Button> ();
		back = back.GetComponent<Button> ();


	}

	public void OnePress() //checks what to enable when stage 1 is pressed 
	{
		stageOne.enabled = true;
		stageTwo.enabled = false;
		stageThree.enabled = false;
		menuOne.enabled = false;
		menuTwo.enabled = false;
		menuThree.enabled = false;
		exitOne.enabled = true;
		exitTwo.enabled = false;
		exitThree.enabled = false;
		yesOne.enabled = true;
		yesTwo.enabled = false;
		yesThree.enabled = false;
		back.enabled = false;

	}

	public void TwoPress() //checks what to enable when stage 2 is pressed 
	{
		stageOne.enabled = false;
		stageTwo.enabled = true;
		stageThree.enabled = false;
		menuOne.enabled = false;
		menuTwo.enabled = false;
		menuThree.enabled = false;
		exitOne.enabled = false;
		exitTwo.enabled = true;
		exitThree.enabled = false;
		yesOne.enabled = false;
		yesTwo.enabled = true;
		yesThree.enabled = false;
		back.enabled = false;
	}

	public void ThreePress() //checks what to enable when stage 3 is pressed 
	{
		stageOne.enabled = false;
		stageTwo.enabled = false;
		stageThree.enabled = true;
		menuOne.enabled = false;
		menuTwo.enabled = false;
		menuThree.enabled = false;
		exitOne.enabled = false;
		exitTwo.enabled = false;
		exitThree.enabled = true;
		yesOne.enabled = false;
		yesTwo.enabled = false;
		yesThree.enabled = true;
		back.enabled = false;
	}
	public void startOne() //loads scene when stage 1 is pressed
	{
		SceneManager.LoadScene("St1Lvl1");
	}
	public void startTwo()//loads scene when stage 2 is pressed
	{
		SceneManager.LoadScene("St2Lvl1");
	}
	public void startThree()//loads scene when stage 3 is pressed
	{
		SceneManager.LoadScene("St3Lvl1");
	}
	public void noPress() //checks what to enable when stage nothing is pressed 
	{
		stageOne.enabled = false;
		stageTwo.enabled = false;
		stageThree.enabled = false;
		menuOne.enabled = true;
		menuTwo.enabled = true;
		menuThree.enabled = true;
		exitOne.enabled = false;
		exitTwo.enabled = false;
		exitThree.enabled = false;
		yesOne.enabled = false;
		yesTwo.enabled = false;
		yesThree.enabled = false;
		back.enabled = true;
	}
	public void backPress() //checks what to enable when back button is pressed 
	{
		SceneManager.LoadScene("titleScreen");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	public void settingChange()
	{
		SceneManager.LoadScene ("Settings");
	}

}
