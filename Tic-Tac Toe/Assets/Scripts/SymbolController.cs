﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolController : MonoBehaviour {

    private string playerSymbol;
    private string opposingSymbol;

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPlayerSymbol(string other)
    {
        playerSymbol = other;
    }

    public void SetOpposingSymbol(string other)
    {
        opposingSymbol = other;
    }

    public string getPlayerSymbol
    {
        get
        {
            return playerSymbol;
        }
    }

    public string getOpposingSymbol
    {
        get
        {
            return opposingSymbol;
        }
    }
}
