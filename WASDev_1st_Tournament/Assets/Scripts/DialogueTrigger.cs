using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void Awake()
    {
        StartCoroutine(StartDialogue());
    }

    public void TriggerDialogue()
    {
        FindObjectOfType < DialogueManager>().StartDialogue(dialogue);
    }

    IEnumerator StartDialogue()
    {
        yield return new WaitForSeconds(2f);

        TriggerDialogue();
    }
}
