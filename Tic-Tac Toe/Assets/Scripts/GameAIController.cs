using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAIController : MonoBehaviour {

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

    public void ComputerMove()
    {
        if (!pGameController.getGameOver)
        {
            int randNum = Random.Range(0, 9);

            GameObject temp = pGameController.GetGameObject(randNum);
            Debug.Assert(temp != null); //safety

            if (temp.GetComponent<Button>().interactable && !pGameController.getGameOver)
            {
                temp.GetComponentInChildren<Text>().text = pSymbolController.getOpposingSymbol;
                temp.GetComponent<SymbolClick>().SetButtonID(2);
                temp.GetComponent<Button>().interactable = false;

                pGameController.SetMoveMade(true);
                pGameController.DecrementMoves();
            }
            else
            {
                ComputerMove();
            }
        }
    }
}
