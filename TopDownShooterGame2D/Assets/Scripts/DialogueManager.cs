using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    //Seting all the variables for which text box and Dialog Text Boxes to use.
    public Text nameText;
    public Text dialogueText;

    //Getting the animator component for switching inbetween text.
    public Animator animator;

    private Queue<string> sentences;

    //Queues all sentances the user wants. 
	void Start () {
        sentences = new Queue<string>();
    }
	
    //Sets dialog box to active. moving it onto the screen. Displays first sentance.
    public void StartDialogue(Dialogue dialogue)
    {

        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    //Displays next Dialog until all sentances queued have been used.
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();

        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Invoke("WaitTime", 7f);
    }

    //Automatic going through sentences, waits 7 seconds before displaying next one.
    public void WaitTime()
    {
        DisplayNextSentence();
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    //Closes dialog box by moving it off of the screen.
    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
