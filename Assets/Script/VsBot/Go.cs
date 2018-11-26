using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Go : MonoBehaviour {

    GameManager gm;


    private void Start()
    {

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();


        // Write a message at each case
        if (gm.IsWin("O"))
        {
            GameObject.Find("Result").GetComponent<Text>().text = "Axe win! Click to take revenge!";

        }
        else if (gm.IsWin("X"))
        {

            GameObject.Find("Result").GetComponent<Text>().text = "You win! Click to play again.";

        }
        else
        {
            GameObject.Find("Result").GetComponent<Text>().text = "The game is hard! Click to get more power.";
        }

        Update();
    }

    private void Update()
    {
      
        //Press any key to restart the game
        if (Input.anyKey)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }
}
