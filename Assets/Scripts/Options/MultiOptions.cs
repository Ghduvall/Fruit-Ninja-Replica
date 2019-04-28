using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiOptions : MonoBehaviour
{

    public Toggle funMode;
    public static bool funModeValue = false;
    int x;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(funModeValue);
        

        funMode.onValueChanged.AddListener(optionCheck);
        
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }

    //Allows toggle to work and save value
    public void optionCheck(bool newValue)
    {
        
        x = x + 1;
        if (x == 1 || x == 3 || x == 5 || x == 7 || x == 9 || x == 11)
        {
            funModeValue = true;
            Debug.Log(funModeValue);
        }
        else if (x == 2 || x == 4 || x ==6 || x ==8 || x ==10 || x ==12)
        {
            funModeValue = false;
            Debug.Log(funModeValue);
        }
        
        
    }
}
