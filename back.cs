﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour {

	// Use this for initialization
	public void goback() //returns back to the level select
	{
		SceneManager.LoadScene ("levelSelect");
	}

}
