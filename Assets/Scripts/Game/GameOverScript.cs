using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    public GameObject gameOverScreen;
    

    // If Player Hit The Play Again Button, With This Code Game Is Gonna Be Restart
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene(). name);
    }

    // If Any Of gameOver Conditions Happening (I Set Them In BirdScript), GameOverScreen Is Gonna Be Active
    public void gameOver()
    {
        gameOverScreen.SetActive(true);

        // audioSource.clip = gameOversound;
        // audioSource.Play();
    }

        public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
