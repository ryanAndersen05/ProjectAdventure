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
        Invoke("displayDialogueInfo", .01f);
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
        if (currentDialogue.currentDialogueInfo.characterName == "-End")
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
        speaker1.sprite = speaker1.GetComponent<PortraitUI>().emotionPortraits[currentDialogue.currentDialogueInfo.currentEmotion];
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
