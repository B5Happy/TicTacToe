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
            ToColorDraw();
            return;
        }
    }

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

    public void ToColor(int b1, int b2, int b3)
    {
        GameObject.Find(b1.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find(b2.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.blue;
        GameObject.Find(b3.ToString()).GetComponent<Button>().GetComponent<Image>().color = Color.blue;
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


