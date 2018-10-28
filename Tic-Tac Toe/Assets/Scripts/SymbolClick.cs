using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SymbolClick : MonoBehaviour {

    private int playerButtonID = 0;

    //reference to symbol controller script
    private SymbolController pSymbolController;

    //reference to game controller script
    private GameController pGameController;

    // Use this for initialization
    void Start () {

        pSymbolController = GameObject.Find("SymbolController").GetComponent<SymbolController>();
        Debug.Assert(pSymbolController != null); //safety

        pGameController = GameObject.Find("GameController").GetComponent<GameController>();
        Debug.Assert(pGameController != null); //safety
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
            playerButtonID = 1;
            pGameController.SetMoveMade(true);
            pGameController.DecrementMoves();
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }

    public int getButtonID
    {
        get
        {
            return playerButtonID;
        }
    }
}
