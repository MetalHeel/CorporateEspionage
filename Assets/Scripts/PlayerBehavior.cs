using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour
{
	private bool touchingWall = false;
    public float speed;

	void Start ()
    {	
	}
	
	void Update ()
    {
		Vector3 position = GetComponent<Rigidbody>().position;

		if (Input.GetKey(KeyCode.A))
			position.x -= speed;

		if (Input.GetKey(KeyCode.D))
			position.x += speed;

		if (Input.GetKey(KeyCode.W))
			position.z += speed;

		if (Input.GetKey(KeyCode.S))
			position.z -= speed;

		GetComponent<Rigidbody>().position = position;

		if(!touchingWall)
			transform.position = position;
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "StaticObject")
			touchingWall = true;
	}

	void OnCollisionExit(Collision collision)
	{
		if (collision.collider.tag == "StaticObject")
			touchingWall = false;
	}
}
