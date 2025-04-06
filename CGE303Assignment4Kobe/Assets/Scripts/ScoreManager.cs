using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TextMeshPro
using TMPro;
//scene manager to load or reload scenes
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    //public static vars can be accessed anywhere but not in inspector
    public static bool gameOver;
    public static bool won;
    public static int score;

    public int scoreToWin;

    //refrence to text box in inspector
    public TMP_Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        //intitialize vars
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textBox.text = "Score: " + score;
        }

        if (score >= scoreToWin)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textBox.text = "You win!\nPress R to try again!";
            }
            else
            {
                textBox.text = "You lose!\nPress R to try again!";

            }

            //restarting after game over
            if (Input.GetKeyDown(KeyCode.R))
            {
                //reload current scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
