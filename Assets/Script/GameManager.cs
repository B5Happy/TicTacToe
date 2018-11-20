using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager: MonoBehaviour {

    public string[] Data = new string[9];
    [SerializeField] List<int> choice = new List<int>();
    public GameObject panel;

    private void Start()
    {
        int turn = Random.Range(0, 2);
        if (turn == 0) ConterPlay();
    }

    public void ConterPlay()
    {
        choice.Clear();

        for(int i= 0; i < Data.Length; i++)
        {
            if (Data[i] == string.Empty)
            {
                choice.Add(i);
            }
        }

        int button = choice[Random.Range(0, choice.Count)];

        Button btn = GameObject.Find(button.ToString()).GetComponent<Button>();

        btn.interactable = false;

        btn.GetComponentInChildren<Text>().text = "O";

        Data[button] = "O";

        if (IsWin("O"))
        {
            Debug.Log("O win");
            panel.SetActive(true);
            return;
        }

        if (IsDraw())
        {
            Debug.Log("Draw");
            panel.SetActive(true);
            return;
        }
    }

    public bool IsWin(string s)
    {

        if (Data[0] == s && Data[1] == s && Data[2] == s ||
           Data[3] == s && Data[4] == s && Data[5] == s ||
           Data[6] == s && Data[7] == s && Data[8] == s ||

           Data[0] == s && Data[3] == s && Data[6] == s ||
           Data[1] == s && Data[4] == s && Data[7] == s ||
           Data[2] == s && Data[5] == s && Data[8] == s ||

           Data[0] == s && Data[4] == s && Data[8] == s ||
           Data[2] == s && Data[4] == s && Data[6] == s)
        {
            return true;
        }

        return false;
    }

    public bool IsDraw()
    {
        for(int i = 0; i<Data.Length; i++)
        {
            if (Data[i] == string.Empty) return false;
        }

        return true;
    }

}
