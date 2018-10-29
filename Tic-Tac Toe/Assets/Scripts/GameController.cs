using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    [SerializeField] private GameObject[] spaces = new GameObject[9];
    [SerializeField] private GameObject gameOverPanelObj;
    [SerializeField] private Text gameOverText;

    private bool isGameOver;
    private bool isMoveMade;
    private bool hasPlayerWon;
    private bool hasComputerWon;
    private int numMoves = 9;

	// Use this for initialization
	void Start () {

        //safety
        Debug.Assert(spaces != null);
        Debug.Assert(gameOverPanelObj != null);
        Debug.Assert(gameOverText != null);

        //set game over panel to not show at start
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
                hasPlayerWon = CheckSquaresIfPlayerWon();
                hasComputerWon = CheckSquaresIfComputerWon();

                if(hasPlayerWon)
                {
                    ShowPlayerWon();
                }

                if(hasComputerWon)
                {
                    ShowComputerWon();
                }

                if (numMoves == 0 && !hasComputerWon && !hasPlayerWon)
                {
                    ShowMatchAsDraw();
                    isGameOver = true;
                }

                isMoveMade = false;
            }
        }
		
	}

    bool CheckSquaresIfPlayerWon()
    {
        if(spaces[0].GetComponent<SymbolClick>().getButtonID == 1 && spaces[1].GetComponent<SymbolClick>().getButtonID == 1 && spaces[2].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else if(spaces[3].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[5].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else if(spaces[6].GetComponent<SymbolClick>().getButtonID == 1 && spaces[7].GetComponent<SymbolClick>().getButtonID == 1 && spaces[8].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else if(spaces[0].GetComponent<SymbolClick>().getButtonID == 1 && spaces[3].GetComponent<SymbolClick>().getButtonID == 1 && spaces[6].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else if(spaces[1].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[7].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else if(spaces[2].GetComponent<SymbolClick>().getButtonID == 1 && spaces[5].GetComponent<SymbolClick>().getButtonID == 1 && spaces[8].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else if(spaces[0].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[8].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else if(spaces[6].GetComponent<SymbolClick>().getButtonID == 1 && spaces[4].GetComponent<SymbolClick>().getButtonID == 1 && spaces[2].GetComponent<SymbolClick>().getButtonID == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool CheckSquaresIfComputerWon()
    {
        if (spaces[0].GetComponent<SymbolClick>().getButtonID == 2 && spaces[1].GetComponent<SymbolClick>().getButtonID == 2 && spaces[2].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else if (spaces[3].GetComponent<SymbolClick>().getButtonID == 2 && spaces[4].GetComponent<SymbolClick>().getButtonID == 2 && spaces[5].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else if (spaces[6].GetComponent<SymbolClick>().getButtonID == 2 && spaces[7].GetComponent<SymbolClick>().getButtonID == 2 && spaces[8].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else if (spaces[0].GetComponent<SymbolClick>().getButtonID == 2 && spaces[3].GetComponent<SymbolClick>().getButtonID == 2 && spaces[6].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else if (spaces[1].GetComponent<SymbolClick>().getButtonID == 2 && spaces[4].GetComponent<SymbolClick>().getButtonID == 2 && spaces[7].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else if (spaces[2].GetComponent<SymbolClick>().getButtonID == 2 && spaces[5].GetComponent<SymbolClick>().getButtonID == 2 && spaces[8].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else if (spaces[0].GetComponent<SymbolClick>().getButtonID == 2 && spaces[4].GetComponent<SymbolClick>().getButtonID == 2 && spaces[8].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else if (spaces[6].GetComponent<SymbolClick>().getButtonID == 2 && spaces[4].GetComponent<SymbolClick>().getButtonID == 2 && spaces[2].GetComponent<SymbolClick>().getButtonID == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void ShowPlayerWon()
    {
        gameOverText.text = "Player Won";
        gameOverPanelObj.SetActive(true);
        isGameOver = true;
    }

    void ShowComputerWon()
    {
        gameOverText.text = "Computer Won";
        gameOverPanelObj.SetActive(true);
        isGameOver = true;
    }

    void ShowMatchAsDraw()
    {
        gameOverText.text = "Match is a Draw";
        gameOverPanelObj.SetActive(true);
        isGameOver = true;
    }

    public void DecrementMoves()
    {
        numMoves--;
        Debug.Log("Moves left: " + numMoves);
    }

    //Set move made method
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

    public int getNumMoves
    {
        get
        {
            return numMoves;
        }
    }

    //Returns a gameobject based on index
    public GameObject GetGameObject(int element)
    {
        return spaces[element];
    }
}
