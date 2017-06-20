using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volume : MonoBehaviour 
{
	public void Volumecontrol(float volumeControl)
	{
		AudioListener.volume = volumeControl; //turns the overall volume into a float
	}
}
