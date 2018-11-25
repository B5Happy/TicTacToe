using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteOXO : MonoBehaviour {

    ManagerVF omg;

    public int role;
    public static bool xplay = true;

    public static int MyScore = 0;
    public static int FriendScore = 0;


    private void Start()
    {
        omg = GameObject.Find("ManagerVF").GetComponent<ManagerVF>();
        GameObject.Find("MyScore").GetComponent<Text>().text = MyScore.ToString();
        GameObject.Find("FriendScore").GetComponent<Text>().text = FriendScore.ToString();
    }



    public void Write()
    {

         if(xplay == true)
         {

             GetComponentInChildren<Text>().text = "X";
             GetComponent<Button>().interactable = false;

             omg.Data[int.Parse(gameObject.name)] = "X";


             if (omg.IsWin("X"))
             {
                omg.panel.SetActive(true);
                MyScore = MyScore + 1;
                GameObject.Find("MyScore").GetComponent<Text>().text = MyScore.ToString();
                return;
             }
             else if (omg.IsDraw())
             {
                 omg.ToColorDraw();
                 omg.panel.SetActive(true);

             }
             else
             {
                 xplay = false;
             }

            xplay = false;
        }
         else
         {
             GetComponentInChildren<Text>().text = "O";
             GetComponent<Button>().interactable = false;

             omg.Data[int.Parse(gameObject.name)] = "O";


             if (omg.IsWin("O"))
             {
                omg.panel.SetActive(true);
                FriendScore = FriendScore + 1;
                GameObject.Find("FriendScore").GetComponent<Text>().text = FriendScore.ToString();
                return;
             }
             else if (omg.IsDraw())
             {
                 omg.ToColorDraw();
                 omg.panel.SetActive(true);

             }
             else
             {
                xplay = true;
            }

            xplay = true;
        }


    }


}

