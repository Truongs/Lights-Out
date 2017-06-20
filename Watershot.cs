using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watershot : MonoBehaviour {
	
	public float speedBubble;


	public PlatformEffector2D Flip;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speedBubble, GetComponent<Rigidbody2D> ().velocity.y);
		if(Flip.transform.localScale.x > 0) //determinds the speed of the crates and where is should spawn
			speedBubble = -speedBubble;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (gameObject);
	} 
}
