using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymusicCG : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{ 
		GameObject A = GameObject.FindGameObjectWithTag ("musicCG");
		Destroy (A);
	}
}
