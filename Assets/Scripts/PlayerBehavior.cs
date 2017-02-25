using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehavior : MonoBehaviour
{
    private float speed = 0.1f;

	void Start ()
    {	
	}
	
	void Update ()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.A))
            position.x -= speed;

        if (Input.GetKey(KeyCode.D))
            position.x += speed;

        if (Input.GetKey(KeyCode.W))
            position.z += speed;

        if (Input.GetKey(KeyCode.S))
            position.z -= speed;

        transform.position = position;
	}
}
