using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueUI : MonoBehaviour {
    public DialogueObject currentDialogue;
    public Text characterName;
    public Text dialogueText;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Submit"))
        {
            advanceDialogue();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            startDialogue();
        }
	}

    void displayDialogueInfo()
    {
        characterName.text = currentDialogue.currentDialogueInfo.characterName;
        dialogueText.text = currentDialogue.currentDialogueInfo.dialogueLine;
    }

    void advanceDialogue()
    {
        currentDialogue.next();
        displayDialogueInfo();
    }

    public void startDialogue()
    {
        displayDialogueInfo();
    }
}
