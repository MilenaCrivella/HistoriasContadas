﻿using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void Restart () 
    {
        if (Input.GetKeyDown("r"))
        {
            Application.LoadLevel("Stage1");
            SoldierVision.Visualizou = false;
        }
	}
	
	void Update () 
    {
        Restart();
	}
}