using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SymbolClick : MonoBehaviour {

    //reference to symbol controller script
    private SymbolController pSymbolController;

    // Use this for initialization
    void Start () {

        pSymbolController = GameObject.Find("SymbolController").GetComponent<SymbolController>();
        Debug.Assert(pSymbolController != null); //safety

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ClickSymbolButton()
    {
        gameObject.GetComponentInChildren<Text>().text = pSymbolController.getPlayerSymbol;
        gameObject.GetComponent<Button>().interactable = false;
    }
}
