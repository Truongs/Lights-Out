using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyCG : MonoBehaviour 
{

	// Use this for initialization
	void Awake()
	{ 
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("musicCG"); //finds gameobjects with tag musiccg
		if (objs.Length > 1)
			Destroy (this.gameObject); //if there is more then two, destroy it

		DontDestroyOnLoad (this.gameObject);

	}

}
