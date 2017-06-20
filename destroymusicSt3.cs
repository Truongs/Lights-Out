using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymusicSt3 : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{ 
		GameObject A = GameObject.FindGameObjectWithTag ("music3");
		Destroy (A);
	}
}
