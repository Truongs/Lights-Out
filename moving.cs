using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour 
{
	private Vector3 posA;

	private Vector3 posB;

	private Vector3 nexPos;


	[SerializeField] //allows it to become public
	private float speed;

	[SerializeField]//allows it to become public
	private Transform childTransform;

	[SerializeField]//allows it to become public
	private Transform transformB;

	// Use this for initialization
	void Start () 
	{
		posA = childTransform.localPosition;
		posB = transformB.localPosition;
		nexPos = posB;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Move (); 
	}
	private void Move()
	{
		childTransform.localPosition = Vector3.MoveTowards (childTransform.localPosition, nexPos, speed * Time.deltaTime);

		if (Vector3.Distance(childTransform.localPosition,nexPos) <= 0.1) //checks if it doesn't pass the nexpos
		{
			ChangeDestination(); 
		}
	}
	private void ChangeDestination()
	{
		nexPos = nexPos != posA ? posA : posB; //makes the next positions either posa or posb
	}

}
