using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float flapStrength;

    public GameOverScript logic;
    public bool birdIsAlive = true;

    
    public AudioSource birdAudio;
    public AudioClip jumpClip;
    public AudioClip fallClip;
    public AudioClip hitClip;

    private Animator anim;

    void Start()
    {
       // In This Line I Connected This Script With GameOverScript To Be Refrences For Eachother To Use gameOver() Function
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameOverScript>();

        anim = GetComponent<Animator>();
    }


    void Update()
    {
        // Make The Bird Flapping
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            MyRigidBody.velocity = Vector2.up * flapStrength;

            // Set The Flapping Animation
            anim.SetTrigger("Flap");
            
            if (birdAudio.isPlaying == false)
            {
               birdAudio.clip = jumpClip;
               birdAudio.Play();
            }
        }
        
        // If Bird Go Higher Or Lower Than Screen Range, Then Game Is Over
        if(MyRigidBody.position.y < -17f)
        {
            logic.gameOver();
            birdIsAlive = false;
            fallClipFunction();
            
        }

        if(MyRigidBody.position.y > 17f)
        {
            logic.gameOver();
            birdIsAlive = false;
            fallClipFunction();
            
        }
    
    }
    
    public void fallClipFunction()
    {
        birdAudio.clip = fallClip;
        birdAudio.Play();    
    }

    // If Bird Hit The Obstacles(Pipes), Then Game Is Over
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;

        birdAudio.clip = hitClip;
        birdAudio.Play();
        }

}
