using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject Pipe;

    // This Is For How Many Seconds It Should Be Between Spawns
    public float spawnRate = 2;

    // This Is To Count Up For Specified Number Of Seconds, Run Some Code, And Then Start The Count Again
    private float timer = 0;


    // This Is For Height Of Pipes
    public float heightOffset = 10;


    void Start()
    {
        // It Make Pipe Immediatly Spawn When Game Is Executed
        spawnPipe();
    }


    void Update()
    {
        // If Timer Still Dosn't Reach The SpawnRate, So Count Up The Timer
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }

        // If Timer Met Or Exceeded The SpawnRate, Then Spawn A Pipe And Start The Timer Again
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        // I Make This Variable Inside Of The Function Because I Want Use Them Just In This Function
        // With These Variables I Access The -y And +y Of Pipes
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // In This Line I Specify The y Of The Pipe And Let The X And Z To Be Default
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}

