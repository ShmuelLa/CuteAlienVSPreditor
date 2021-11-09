using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Main player mover component, moves the player via a fixed speed to any direction.
 * Supports long presses using the GetKey function
 */
public class Mover : MonoBehaviour
{
    [SerializeField] public float playerSpeed = 1f;

    void Update()
    {
        if (Input.GetKey("left"))
        {
            Vector3 position = this.transform.position;
            position.x -= playerSpeed;
            this.transform.position = position;
        }
        if (Input.GetKey("right"))
        {
            Vector3 position = this.transform.position;
            position.x += playerSpeed;
            this.transform.position = position;
        }
        if (Input.GetKey("up"))
        {
            Vector3 position = this.transform.position;
            position.y += playerSpeed;
            this.transform.position = position;
        }
        if (Input.GetKey("down"))
        {
            Vector3 position = this.transform.position;
            position.y -= playerSpeed;
            this.transform.position = position;
        }
    }
}
