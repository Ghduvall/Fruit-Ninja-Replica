using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ChangeScene : MonoBehaviour
{
    public Button introContinueBtn;
    public Button optionsBtn;
    public Button saveOptionsBtn;
    public Button startBtn;
    public Button restartBtn;

    public SaveName saveName;

    
    // Start is called before the first frame update
    void Start()
    {
        
            introContinueBtn.onClick.AddListener(scenePreScore);

            optionsBtn.onClick.AddListener(sceneOptions);

            saveOptionsBtn.onClick.AddListener(sceneIntro);

            startBtn.onClick.AddListener(sceneMain);

            restartBtn.onClick.AddListener(sceneIntro);



       
        


    }

    public void sceneIntro()
    {
        GameScore.currentTimer = 0;
        GameScore.playerScore = 0;
        SceneManager.LoadScene(0);
    }
    public void sceneOptions()
    {
        SceneManager.LoadScene(1);
    }
    public void scenePreScore()
    {
        SceneManager.LoadScene(2);
    }
    public void sceneMain()
    {
        //Debug.Log(saveName.nName);
        saveName.nameInput();
        //Debug.Log(saveName.nName);
        SceneManager.LoadScene(3);
    }
    public void sceneEnd()
    {
        SceneManager.LoadScene(4);
    }
    
}
