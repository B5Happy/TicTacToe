using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBox : MonoBehaviour {

    GameManager gm;
    public static int MyScore = 0;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        GameObject.Find("MyScore").GetComponent<Text>().text = MyScore.ToString();
    }

    public void WriteX()
    {
        GetComponentInChildren<Text>().text = "X";
        GetComponent<Button>().interactable = false;

        gm.Data[int.Parse(gameObject.name)] = "X";

        
        if (gm.IsWin("X"))
        {
            Debug.Log("X win");
            gm.panel.SetActive(true);
            MyScore = MyScore + 1;
            GameObject.Find("MyScore").GetComponent<Text>().text = MyScore.ToString();
            return;
        } 
        else if (gm.IsDraw())
        {
            
            Debug.Log("Draw");
            gm.ToColorDraw();
            gm.panel.SetActive(true);

        }
        else
        {
            gm.ConterPlay();
        }


    }
}
