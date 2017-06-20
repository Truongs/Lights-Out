using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroySt1 : MonoBehaviour 
{

	// Use this for initialization
	void Awake()
	{ 
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("music1");
		if (objs.Length > 1)
			Destroy (this.gameObject);

		DontDestroyOnLoad (this.gameObject);

	}

}
