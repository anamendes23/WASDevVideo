using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementManager : MonoBehaviour
{
    //get all pictures
    [SerializeField]
    private GameObject groupPic;
    [SerializeField]
    private GameObject groupPicTournament;
    [SerializeField]
    private GameObject wiiPlayers;
    [SerializeField]
    private GameObject boardGames;
    [SerializeField]
    private GameObject jenda;
    [SerializeField]
    private GameObject robots;
    [SerializeField]
    private GameObject cybersecurityClub;
    [SerializeField]
    private GameObject win1;
    [SerializeField]
    private GameObject win2;
    [SerializeField]
    private GameObject win3;
    [SerializeField]
    private GameObject win4;    
    [SerializeField]
    private GameObject marioKPlayers;
    [SerializeField]
    private GameObject SNConsole;
    [SerializeField]
    private GameObject gameCubeConsole;
    [SerializeField]
    private GameObject after1;
    [SerializeField]
    private GameObject after2;
    [SerializeField]
    private GameObject vr;
    [SerializeField]
    private GameObject fader;
    //get animations
    [SerializeField]
    private Animator fadeAnim;

    private void Awake()
    {
        StartCoroutine(AnimatePictures());
    }

    IEnumerator AnimatePictures()
    {
        yield return new WaitForSeconds(30f);
        fader.SetActive(true);
        fadeAnim.Play("FadeIn");

        yield return new WaitForSeconds(35f);
        groupPic.SetActive(false);
        fader.SetActive(false);
    }
}
