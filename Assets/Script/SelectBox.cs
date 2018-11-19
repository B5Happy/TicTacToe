using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBox : MonoBehaviour {

    GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void WriteX()
    {
        GetComponentInChildren<Text>().text = "X";
        GetComponent<Button>().interactable = false;

        gm.Data[int.Parse(gameObject.name)] = "X";

        
        if (gm.IsWin("X"))
        {
            Debug.Log("X win");
            return;
        } 
        else if (gm.IsDraw())
        {
            
            Debug.Log("Draw");
             
        }
        else
        {
            gm.ConterPlay();
        }


    }
}
