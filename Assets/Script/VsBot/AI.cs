﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AI {

    List<int> choice = new List<int>();
    string[] DataAI = new string[9]; 

    public int BestPlay()
    {
        string[] source = GameObject.Find("GameManager").GetComponent<GameManager>().Data;
        Array.Copy(source, DataAI, source.Length);
        choice.Clear();

        for (int i = 0; i < DataAI.Length; i++)
        {
            if (DataAI[i] == string.Empty)
            {
                choice.Add(i);
            }
        }

        // Try to search for a winning play/move
        for(int i=0; i < DataAI.Length; i++)
        {
            if(DataAI[i] == String.Empty)
            {
                DataAI[i] = "O";
                if(IsWin("O"))
                {                  
                    return i;
                }

                DataAI[i] = string.Empty;
            }
        }

        //Try to block the enemie to win 
        for (int i = 0; i < DataAI.Length; i++)
        {
            if (DataAI[i] == String.Empty)
            {
                DataAI[i] = "X";
                if (IsWin("X"))
                {
                    return i;
                }

                DataAI[i] = string.Empty;
            }
        }

        return choice[UnityEngine.Random.Range(0, choice.Count)];


    }

    // Listed different winning possibility
    public bool IsWin(string s)
    {

        if (DataAI[0] == s && DataAI[1] == s && DataAI[2] == s ||
           DataAI[3] == s && DataAI[4] == s && DataAI[5] == s ||
           DataAI[6] == s && DataAI[7] == s && DataAI[8] == s ||

           DataAI[0] == s && DataAI[3] == s && DataAI[6] == s ||
           DataAI[1] == s && DataAI[4] == s && DataAI[7] == s ||
           DataAI[2] == s && DataAI[5] == s && DataAI[8] == s ||

           DataAI[0] == s && DataAI[4] == s && DataAI[8] == s ||
           DataAI[2] == s && DataAI[4] == s && DataAI[6] == s)
        {
            return true;
        }

        return false;
    }
}
