using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField] private GameObject[] spaces = new GameObject[9];
    [SerializeField] private GameObject gameOverPanelObj;

    private bool isGameOver;
    private bool isMoveMade;
    private int numMoves = 9;

	// Use this for initialization
	void Start () {

        Debug.Assert(spaces != null);
        Debug.Assert(gameOverPanelObj != null);

        gameOverPanelObj.SetActive(false);

        isMoveMade = false;
        isGameOver = false;

        Debug.Log("Initial moves: " + numMoves);
	}
	
	// Update is called once per frame
	void Update () {

        if(!isGameOver)
        {
            if (isMoveMade)
            {
                CheckSquaresIfPlayerWon();
                isMoveMade = false;
            }
        }
		
	}

    void CheckSquaresIfPlayerWon()
    {
        if(spaces[0].GetComponent<SymbolClick>().getButtonID == 1 && spaces[1].GetComponent<SymbolClick>().getButtonID == 1 && spaces[2].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
        else if(spaces[3].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[5].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
        else if(spaces[6].GetComponent<SymbolClick>().getButtonID == 1 && spaces[7].GetComponent<SymbolClick>().getButtonID == 1 && spaces[8].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
        else if(spaces[0].GetComponent<SymbolClick>().getButtonID == 1 && spaces[3].GetComponent<SymbolClick>().getButtonID == 1 && spaces[6].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
        else if(spaces[1].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[7].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
        else if(spaces[2].GetComponent<SymbolClick>().getButtonID == 1 && spaces[5].GetComponent<SymbolClick>().getButtonID == 1 && spaces[8].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
        else if(spaces[0].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[8].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
        else if(spaces[6].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[2].GetComponent<SymbolClick>().getButtonID == 1)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        gameOverPanelObj.SetActive(true);
        isGameOver = true;
    }

    void CheckSquaresIfCompWon()
    {
        isGameOver = true;
    }

    public void DecrementMoves()
    {
        numMoves--;
        Debug.Log("Moves left: " + numMoves);
    }

    //Set move method
    public void SetMoveMade(bool other)
    {
        isMoveMade = other;
    }

    //Accessors
    public bool getGameOver
    {
        get
        {
            return isGameOver;
        }
    }

    public bool getMoveMade
    {
        get
        {
            return isMoveMade;
        }
    }
}
