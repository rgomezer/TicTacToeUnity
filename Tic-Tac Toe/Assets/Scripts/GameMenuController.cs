﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour {

    //Main Game Menu
    [SerializeField] private GameObject backButtonObj;
    [SerializeField] private GameObject quitButtonObj;

    // Use this for initialization
    void Start () {

        //safety
        Debug.Assert(quitButtonObj != null);
        Debug.Assert(backButtonObj != null);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void DestroySymbolController()
    {
        //Garbage collection
        GameObject temp = GameObject.Find("SymbolController");
        Debug.Assert(temp != null); //safety

        Destroy(temp);
    }

    public void GoBackToMainMenu()
    {
        DestroySymbolController();
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
