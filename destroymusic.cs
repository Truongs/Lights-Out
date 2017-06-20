using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymusic : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{ 
		GameObject A = GameObject.FindGameObjectWithTag ("music");
		Destroy (A);
	}
}
