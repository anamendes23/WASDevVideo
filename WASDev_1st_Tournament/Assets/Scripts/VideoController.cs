using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public static VideoController instance;
    // Start is called before the first frame update
    void Awake()
    {
        MakeSingleton();
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(8f);
        //yield return StartCoroutine(Coroutine.WaitForRealSeconds(8f));

        SceneFader.instance.LoadScene("Content");

    }    

    void MakeSingleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
