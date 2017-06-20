using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymusicSt1 : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{ 
		GameObject A = GameObject.FindGameObjectWithTag ("music1");
		Destroy (A);
	}
}
