using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Pause()
    {

    }

    public void Continue()
    {

    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
