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
		popuptext = popuptext.GetComponent<Canvas> ();//the text that pops up is a canvas
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.tag == "Player") //checks if the players touches the trigger
			popuptext.enabled = false;
	}
}
