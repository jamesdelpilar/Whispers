﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
            Application.Quit();
        }
    }
}
