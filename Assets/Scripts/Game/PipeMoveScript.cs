using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -45;

    void Update()
    {
        // Make The Pipes Move
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;


    // Make The Pipes Deleted When They Went Out Of The Camera Range (To Free Up Memory)
    if (transform.position.x < deadZone)
    {
        // Debug.Log("Pipe Deleted");
        Destroy(gameObject);
    }
}
}
