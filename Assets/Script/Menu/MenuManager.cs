using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {


    public void VsBot()
    {
        SceneManager.LoadScene("VsBot");
    }

    public void VsFriend()
    {
        SceneManager.LoadScene("VsFriend");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }


}
