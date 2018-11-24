using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go : MonoBehaviour {

    GameManager gm;

    private void Update()
    {
        //Press any key to restart the game
        if (Input.anyKey)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //gm.Restart();
        }
    }
}
