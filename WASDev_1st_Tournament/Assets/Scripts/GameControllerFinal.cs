using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerFinal : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Close()
    {
        Application.Quit();
    }
}
