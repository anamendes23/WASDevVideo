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
    private GameObject fader;
    [SerializeField]
    private GameObject faderOut;
    [SerializeField]
    private GameObject Mario321;
    //get animations
    [SerializeField]
    private Animator groupPicTournamentAnim;
    [SerializeField]
    private Animator wiiPlayersAnim;
    [SerializeField]
    private Animator boardGamesAnim;
    [SerializeField]
    private Animator jendaAnim;
    [SerializeField]
    private Animator robotsAnim;
    [SerializeField]
    private Animator cybersecurityClubAnim;
    [SerializeField]
    private Animator marioKPlayersAnim;
    [SerializeField]
    private Animator SNConsoleAnim;
    [SerializeField]
    private Animator gameCubeConsoleAnim;
    [SerializeField]
    private Animator fadeAnim;
    [SerializeField]
    private Animator fadeOutAnim;

    private void Awake()
    {
        StartCoroutine(AnimatePictures());
    }

    IEnumerator AnimatePictures()
    {
        yield return new WaitForSeconds(30f);
        fader.SetActive(true);
        fadeAnim.Play("FadeIn");

        yield return new WaitForSeconds(7f);
        groupPic.SetActive(false);
        fader.SetActive(false);

        yield return new WaitForSeconds(15f);
        marioKPlayers.SetActive(true);
        marioKPlayersAnim.Play("MarioKPlayers");
        Mario321.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        wiiPlayers.SetActive(true);
        wiiPlayersAnim.Play("WiiPlayers");
        yield return new WaitForSeconds(2.5f);
        boardGames.SetActive(true);
        boardGamesAnim.Play("BoardGames");
        yield return new WaitForSeconds(2.5f);
        jenda.SetActive(true);
        jendaAnim.Play("Jenga");
        marioKPlayers.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        robots.SetActive(true);
        robotsAnim.Play("Robots");
        wiiPlayers.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        cybersecurityClub.SetActive(true);
        cybersecurityClubAnim.Play("Cybersecurity");
        boardGames.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        SNConsole.SetActive(true);
        SNConsoleAnim.Play("SNES");
        jenda.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        gameCubeConsole.SetActive(true);
        gameCubeConsoleAnim.Play("GameCube");
        robots.SetActive(false);
        yield return new WaitForSeconds(5f);
        groupPicTournament.SetActive(true);
        groupPicTournamentAnim.Play("Group");
        cybersecurityClub.SetActive(false);
        yield return new WaitForSeconds(10f);
        //deactivate everything
        SNConsole.SetActive(false);
        gameCubeConsole.SetActive(false);
        groupPicTournament.SetActive(false);
        //fades
        fader.SetActive(true);
        fadeAnim.Play("FadeIn");
        yield return new WaitForSeconds(10f);
        faderOut.SetActive(true);
        fadeOutAnim.Play("FadeOut");
        fader.SetActive(false);
        yield return new WaitForSeconds(2f);
        win1.SetActive(true);
        win2.SetActive(true);
        win3.SetActive(true);
        win4.SetActive(true);
    }
}
