using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtons : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void TitleMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }


}
