using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager: MonoBehaviour {

    //Where we will store the Data
    public string[] Data = new string[9];

    public GameObject panel;
    public static int AxeScore = 1;

    //Call AI class for the computer choise which box to tick
    AI Bot = new AI();


    private void Start()
    {
        //Choise which player start playing first
        int turn = Random.Range(0, 2);
        if (turn == 0) ConterPlay();
    }



    public void ConterPlay()
    {


        int button = Bot.BestPlay();

        Button btn = GameObject.Find(button.ToString()).GetComponent<Button>();

        btn.interactable = false;

        btn.GetComponentInChildren<Text>().text = "O";

        Data[button] = "O";

        
        if (IsWin("O"))
        {
            //Debug.Log("O win");
            panel.SetActive(true);
            //GameObject.Find("AxeScore").GetComponent<Text>().text = AxeScore.ToString();
            //Start();
            return;
        }

        if (IsDraw())
        {
            //Debug.Log("Draw");
            panel.SetActive(true);
            ToColorDraw();
            return;
        }
    }

    // To decide the winner we will go trought each winning case
    public bool IsWin(string s)
    {

        if (Data[0] == s && Data[1] == s && Data[2] == s)
        {
            ToColor(0, 1, 2);
            return true;
        }

        if (Data[3] == s && Data[4] == s && Data[5] == s)
        {
            ToColor(3, 4, 5);
            return true;
        }

        if (Data[6] == s && Data[7] == s && Data[8] == s)
        {
            ToColor(6, 7, 8);
            return true;
        }

        if (Data[0] == s && Data[3] == s && Data[6] == s)
        {
            ToColor(0, 3, 6);
            return true;
        }

        if (Data[1] == s && Data[4] == s && Data[7] == s)
        {
            ToColor(1, 4, 7);
            return true;
        }

        if (Data[2] == s && Data[5] == s && Data[8] == s)
        {
            ToColor(2, 5, 8);
            return true;
        }

        if (Data[0] == s && Data[4] == s && Data[8] == s)
        {
            ToColor(0, 4, 8);
            return true;
        }

        if (Data[2] == s && Data[4] == s && Data[6] == s)
        {
            ToColor(2, 4, 6);
            return true;
        }

        return false;
    }

    //To show the winnng move
    public void ToColor(int b1, int b2, int b3)
    {
        GameObject.Find(b1.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find(b2.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find(b3.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        
    }

    public void Restart()
    {
        /*GameObject.Find("0").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("1").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("2").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("3").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("4").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("5").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("6").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("7").GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find("8").GetComponent<Button>().GetComponent<Image>().color = Color.blue;*/

        for(int i = 0; i<8; i++)
        {
            GameObject.Find(i.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.white;
        }

        Start();

    }

    public bool IsDraw()
    {
        for(int i = 0; i<Data.Length; i++)
        {
            if (Data[i] == string.Empty) return false;
        }

        return true;
    }

    public void ToColorDraw()
    {
        for(int i=0; i<Data.Length; i++)
        {
            GameObject.Find(i.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.grey;
        }

    }


}


