using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Go2 : MonoBehaviour {


    ManagerVF rofl;


    private void Start()
    {

        rofl = GameObject.Find("ManagerVF").GetComponent<ManagerVF>();


        // Write a message at each case
        if (rofl.IsWin("O"))
        {
            GameObject.Find("Result").GetComponent<Text>().text = "Your friend win! Click to take revenge!";

        }
        else if (rofl.IsWin("X"))
        {

            GameObject.Find("Result").GetComponent<Text>().text = "Ez win! Click to smak again.";

        }
        else
        {
            GameObject.Find("Result").GetComponent<Text>().text = "The game is hard! Click to get more chance.";
        }

        Update();
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
