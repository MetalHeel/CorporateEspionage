using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraBehavior : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
    }

    void Update()
    {
        Camera camera = GetComponent<Camera>();

		float widthThreshold = Screen.width * 0.4f;
		float heightThreshold = Screen.height / 3.0f;

		Vector3 screenPos = camera.WorldToScreenPoint(player.transform.position);
		Vector3 cameraPos = transform.position;

		float speed = player.GetComponent<PlayerBehavior>().speed;

        if (screenPos.x < widthThreshold)
            cameraPos.x -= speed;

        if (screenPos.x > Screen.width - widthThreshold)
            cameraPos.x += speed;

        if (screenPos.y > Screen.height - heightThreshold)
            cameraPos.z += speed;

        if (screenPos.y < heightThreshold)
            cameraPos.z -= speed;

		transform.position = cameraPos;
    }
}
