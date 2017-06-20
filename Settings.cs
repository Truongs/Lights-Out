using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {

	public GameObject mainmenuHolder;
	public GameObject optionholder;


	// Use this for initialization
	void Start () 
	{
		SceneManager.LoadScene ("levelSelect"); 
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OptionsMenu()
	{
		mainmenuHolder.SetActive (false);
		optionholder.SetActive (true);

	}

	void MainMenu()
	{
		mainmenuHolder.SetActive (false);
		optionholder.SetActive (true);
		
	}

	public void SetScreenResolution(int i)
	{
		
	}

	public void SetFullscreen (bool isFullscreen)
	{
	}

	public void SetVolume(float value)
	{
		
	}
}
