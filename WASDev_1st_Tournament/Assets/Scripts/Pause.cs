using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    bool paused = false;

    [SerializeField]
    private Button pauseButton;
    [SerializeField]
    private Sprite pause;
    [SerializeField]
    private Sprite play;

    public void PauseAndContinue()
    {
        if (paused)
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
            paused = false;
            pauseButton.image.sprite = pause;
        }
        else
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
            paused = true;
            pauseButton.image.sprite = play;
        }
    }

    public void QuitVideo()
    {
        Application.Quit();
    }
}
