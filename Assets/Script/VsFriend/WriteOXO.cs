using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteOXO : MonoBehaviour {

    ManagerVF omg;

    public int role;
    public static bool xplay = true;
    

    private void Start()
    {
        omg = GameObject.Find("ManagerVF").GetComponent<ManagerVF>();
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
                 Debug.Log("X win");
                 omg.panel.SetActive(true);
                 return;
             }
             else if (omg.IsDraw())
             {

                 Debug.Log("Draw");
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
                 Debug.Log("O win");
                 omg.panel.SetActive(true);
                 return;
             }
             else if (omg.IsDraw())
             {

                 Debug.Log("Draw");
                 omg.ToColorDraw();
                 omg.panel.SetActive(true);

             }
             else
             {
                xplay = true;
            }

            xplay = true;
        }

        /* if (role == 0)
         {





         }



         if (role == 1)
         {





         }*/




    }


}

