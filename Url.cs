using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Url : MonoBehaviour {

	public string URL; 

	public void urlLinkOrWeb() 
	{
		Application.OpenURL(URL);
	}﻿

}
