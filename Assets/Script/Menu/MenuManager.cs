using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public static string LastScene = "Menu";
    

    public void VsBot()
    {
        SceneManager.LoadScene("VsBot");
        LastScene = "VsBot";
    }

    public void VsFriend()
    {
        SceneManager.LoadScene("VsFriend");
        LastScene = "VsFriend";
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        LastScene = "Menu";
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void BackToScene()
    {
        SceneManager.LoadScene(LastScene);
    }

    public void Quit()
    {
        Application.Quit();
    }


}
