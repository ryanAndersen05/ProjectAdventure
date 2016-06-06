using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueUI : MonoBehaviour {
    public DialogueObject currentDialogue;
    public Image speaker1;
    public Text characterName;
    public Text dialogueText;

	// Use this for initialization
	void Start () {
        Invoke("displayDialogueInfo", .1f);
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
        if (characterName.text == "-End")
        {
            endDialogue();
            return;
        }
        characterName.text = currentDialogue.currentDialogueInfo.characterName;
        dialogueText.text = currentDialogue.currentDialogueInfo.dialogueLine;
        displayPortraitImage();
    }

    void displayPortraitImage()
    {

    }

    void advanceDialogue()
    {
        currentDialogue.next();
        displayDialogueInfo();
    }

    public void startDialogue()
    {
        displayDialogueInfo();
        gameObject.SetActive(true);
    }

    public void endDialogue()
    {
        gameObject.SetActive(false);
    }
}
