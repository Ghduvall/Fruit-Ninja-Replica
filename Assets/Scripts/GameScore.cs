using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScore : MonoBehaviour
{
    public ChangeScene changeScene;

    public static int playerScore = 0;
    public Text scoreText;
    public static string score = "Score: ";
    public static int playerIndex;
    //public static bool funMode = false;


    public Text gameTimer;
    public static string timer = "Time: ";
    public static float currentTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score + playerScore.ToString();
        gameTimer.text = timer + currentTimer.ToString("F0");
        currentTimer += Time.deltaTime;
        funModeCheck();
    }

    public void funModeCheck()
    {
        if (MultiOptions.funModeValue == true)
        {
         
            if (currentTimer > 60)
            {
                SceneManager.LoadScene(4);
            }
        }
        else if(playerScore == 10)
        {
            SceneManager.LoadScene(4);
        }
    }
}
