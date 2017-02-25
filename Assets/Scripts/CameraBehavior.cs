using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraBehavior : MonoBehaviour
{
    public GameObject player;

    private float speed = 0.1f;

    void Start()
    {
    }

    // Todo: Have a threshold position maybe.
    void Update()
    {
        Camera camera = GetComponent<Camera>();

        Vector3 position = transform.position;

        float height = 2f * camera.orthographicSize;
        float width = height * camera.aspect;

        float heightQ = height / 4.0f;
        float widthQ = width / 4.0f;

        if (player.transform.position.x < transform.position.x - (2 * widthQ))
            position.x -= speed;

        if (player.transform.position.x > transform.position.x + (2 * widthQ))
            position.x += speed;

        if (player.transform.position.y > transform.position.y + (2 * heightQ))
            position.y += speed;

        if (player.transform.position.y < transform.position.y - (2 * heightQ))
            position.y -= speed;
    }
}
