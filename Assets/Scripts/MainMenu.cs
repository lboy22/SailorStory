using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void BeginGame()
    {
        //Fade music out.

        //Load game scene.
        SceneManager.LoadScene("LevelOne");
    }

    public void Credits()
    {
        //Fade music out.

        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        //Wait two seconds before exiting game.

        //Exit build game.
        Application.Quit();

        //Exit editor game mode.
        //  UnityEditor.EditorApplication.isPlaying = false;
    }
}
