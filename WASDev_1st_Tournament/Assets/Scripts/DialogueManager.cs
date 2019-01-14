using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    [SerializeField]
    private Animator anim;
    //Audios
    [SerializeField]
    private AudioSource keyboard;
    [SerializeField]
    private AudioSource bgMusic;
    [SerializeField]
    private AudioSource bgMusicMario;
    //Videos
    [SerializeField]
    private VideoPlayer marioVP321;
    [SerializeField]
    private VideoPlayer vr;
    [SerializeField]
    private VideoPlayer winnersBg;
    [SerializeField]
    private GameObject VR;
    [SerializeField]
    private GameObject BG;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    IEnumerator TypeSentence(string sentence)
    {       

        dialogueText.text = "";

        keyboard.Play();

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            //wait one single frame
            //yield return null;
            yield return new WaitForSeconds(0.05f);
        }

        keyboard.Stop();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        bgMusic.volume = 0.1f;
        anim.SetBool("IsOpen", true);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        StartCoroutine(ChangeSentence());
    }

    IEnumerator ChangeSentence()
    {
        DisplayNextSentence();
        yield return new WaitForSeconds(5f);

        DisplayNextSentence();
        yield return new WaitForSeconds(10f);

        DisplayNextSentence();
        yield return new WaitForSeconds(9f);

        DisplayNextSentence();
        yield return new WaitForSeconds(5f);

        anim.SetBool("IsOpen", false);
        bgMusic.volume = 1.0f;
        //DisplayNextSentence();
        yield return new WaitForSeconds(3f);
        bgMusicMario.Play();

        yield return new WaitForSeconds(12f);
        marioVP321.Play();

        yield return new WaitForSeconds(35f);
        VR.SetActive(true);
        vr.Play();        

        yield return new WaitForSeconds(20f);
        VR.SetActive(false);
        BG.SetActive(false);
        winnersBg.Play();
        
    }

    public void DisplayNextSentence()
    {       

        //if (sentences.Count == 0)
        //{
        //    EndDialogue();
        //    return;
        //}

        string sentence = sentences.Dequeue();
        //StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    //public void EndDialogue()
    //{
    //    anim.SetBool("IsOpen", false);
    //    bgMusic.volume = 1.0f;
    //}
}
