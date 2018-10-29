using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SymbolClick : MonoBehaviour {

    private int buttonID = 0;

    //reference to symbol controller script
    private SymbolController pSymbolController;

    //reference to game controller script
    private GameController pGameController;

    //reference to game ai controller script
    private GameAIController pGameAIController;

    // Use this for initialization
    void Start () {

        pSymbolController = GameObject.Find("SymbolController").GetComponent<SymbolController>();
        Debug.Assert(pSymbolController != null); //safety

        pGameController = GameObject.Find("GameController").GetComponent<GameController>();
        Debug.Assert(pGameController != null); //safety

        pGameAIController = GameObject.Find("GameController").GetComponent<GameAIController>();
        Debug.Assert(pGameAIController != null); //safety
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickSymbolButton()
    {
        if (!pGameController.getGameOver)
        {
            gameObject.GetComponentInChildren<Text>().text = pSymbolController.getPlayerSymbol;
            gameObject.GetComponent<Button>().interactable = false;
            buttonID = 1;
            pGameController.SetMoveMade(true);
            pGameController.DecrementMoves();

            if (pGameController.getNumMoves > 1)
            {
                pGameAIController.ComputerMove();
            }
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }

    public void SetButtonID(int other)
    {
        buttonID = other;
    }

    public int getButtonID
    {
        get
        {
            return buttonID;
        }
    }
}
