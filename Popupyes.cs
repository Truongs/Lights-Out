using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Popupyes : MonoBehaviour {
	
	public Canvas popuptext;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
			popuptext.enabled = true;
	}
}
