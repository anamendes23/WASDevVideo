using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    [SerializeField]
    private Animator anim;

    [SerializeField]
    private AudioSource keyboard;

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
            yield return new WaitForSeconds(0.1f);
        }

        keyboard.Stop();
    }

    public void StartDialogue(Dialogue dialogue)
    {
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
        yield return new WaitForSeconds(2f);

        DisplayNextSentence();
        yield return new WaitForSeconds(2f);

        DisplayNextSentence();
        yield return new WaitForSeconds(2f);

        DisplayNextSentence();
        yield return new WaitForSeconds(2f);
    }

    public void DisplayNextSentence()
    {       

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public void EndDialogue()
    {
        anim.SetBool("IsOpen", false);
    }
}
