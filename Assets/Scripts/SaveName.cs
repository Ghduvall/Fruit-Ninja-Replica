using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;
public class SaveName : MonoBehaviour
{
    public InputField NewName;

    public static string nName = "hop0";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void nameInput()
    {
        nName = NewName.text;
        
    }
    
}
