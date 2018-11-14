using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;

    //will start the normal dialog button each time the game runs.
    public void Start()
    {
        //Delays the Function from being called for 1 second.
        Invoke("TriggerDialogue", 1f);
    }

    //This Was when i wanted it to start on a button.
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
