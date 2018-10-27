using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    //Main Game Menu
    [SerializeField] private GameObject playButtonObj;
    [SerializeField] private GameObject quitButtonObj;

    //Select Symbol Menu
    [SerializeField] private GameObject selectText;
    [SerializeField] private GameObject goBackButtonObj;
    [SerializeField] private GameObject XSymbolButtonObj;
    [SerializeField] private GameObject OSymbolButtonObj;

    //reference to symbol controller script
    private SymbolController pSymbolController;

    // Use this for initialization
    void Start () {

        pSymbolController = GameObject.Find("SymbolController").GetComponent<SymbolController>();
        Debug.Assert(pSymbolController != null); //safety

        //Safety
        Debug.Assert(playButtonObj != null);
        Debug.Assert(quitButtonObj != null);
        Debug.Assert(goBackButtonObj != null);
        Debug.Assert(XSymbolButtonObj != null);
        Debug.Assert(OSymbolButtonObj != null);
        Debug.Assert(selectText != null);

        //Initially set these to inactive since we are in the main menu first
        goBackButtonObj.SetActive(false);
        XSymbolButtonObj.SetActive(false);
        OSymbolButtonObj.SetActive(false);
        selectText.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame()
    {     
        playButtonObj.SetActive(false);
        quitButtonObj.SetActive(false);

        goBackButtonObj.SetActive(true);
        XSymbolButtonObj.SetActive(true);
        OSymbolButtonObj.SetActive(true);
        selectText.SetActive(true);
    }

    public void GoBackToMainMenu()
    {
        playButtonObj.SetActive(true);
        quitButtonObj.SetActive(true);

        goBackButtonObj.SetActive(false);
        XSymbolButtonObj.SetActive(false);
        OSymbolButtonObj.SetActive(false);
        selectText.SetActive(false);
    }

    public void SelectPlayerSymbolO()
    {
        pSymbolController.SetPlayerSymbol("O");
        pSymbolController.SetOpposingSymbol("X");

        Debug.Log("Set player symbol to: " +pSymbolController.getPlayerSymbol);
        Debug.Log("Set opposing symbol to: " + pSymbolController.getOpposingSymbol);

        SceneManager.LoadScene(1);
    }

    public void SelectPlayerSymbolX()
    {
        pSymbolController.SetPlayerSymbol("X");
        pSymbolController.SetOpposingSymbol("O");

        Debug.Log("Set player symbol to: " + pSymbolController.getPlayerSymbol);
        Debug.Log("Set opposing symbol to: " + pSymbolController.getOpposingSymbol);

        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
