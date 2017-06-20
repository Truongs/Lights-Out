using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class popUpText : MonoBehaviour {
	
	public Canvas popuptext;

	// Use this for initialization
	void Start () 
	{
		popuptext = popuptext.GetComponent<Canvas> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
			popuptext.enabled = false;
	}
}
