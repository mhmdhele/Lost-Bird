using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScore;
    
    public AudioSource scoreAudio;
    public AudioClip scoreClip;


    // With This Line Whenever We Start The Game, It Displayed The HighScore
    void Start ()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    
    public void addScore(int scoreToAdd)
    {
        // This Code Count Up The Score
        playerScore = playerScore + scoreToAdd;

        // This Code Showing The Score In UI
        scoreText.text = playerScore.ToString();


        // In This Line I Make The HighScore UI To Count Up When Bird Reach The Higher Score
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            
        PlayerPrefs.SetInt("HighScore", playerScore);

        // With This Line I Make The UI Count Up In The Moment With Bird That Getting Higher Score
        highScore.text = playerScore.ToString();
        }

        scoreAudio.clip = scoreClip;
        scoreAudio.Play();
    }

    public void Reset ()
    {
        // PlayerPrefs.DeleteAll();

        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "0";
    }
}
