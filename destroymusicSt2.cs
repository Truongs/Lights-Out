using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymusicSt2 : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{ 
		GameObject A = GameObject.FindGameObjectWithTag ("music2");
		Destroy (A);
	}
}
