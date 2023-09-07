using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public ScoreScript Logic;


    void Start()
    {
        // In This Line I Connected This Script With ScoreScript To Be Refrences For Eachother
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreScript>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 3 Is The Number Of Bird Layer
        if (collision.gameObject.layer == 3)
        {

        // With This Trick I Keep It Open For Future Ideas And Make It Less Rigid
        Logic.addScore(1);
        
        }
    }
}
