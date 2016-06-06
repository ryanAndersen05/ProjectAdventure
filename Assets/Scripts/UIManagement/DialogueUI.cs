using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueUI : MonoBehaviour {
    public DialogueObject currentDialogue;
    public Image[] speakers = new Image[2];
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
        if (currentDialogue.currentDialogueInfo.characterName == "-End")
        {
            endDialogue();
            return;
        }
        displayCharacterName();
        dialogueText.text = currentDialogue.currentDialogueInfo.dialogueLine;
        displayPortraitImage();
    }

    void displayCharacterName()
    {
        characterName.text = currentDialogue.currentDialogueInfo.characterName;
    }

    void displayPortraitImage()
    {
        speakers[0].sprite = CharacterImageManager.getCharacter(characterName.text).emotionPortraits[currentDialogue.currentDialogueInfo.currentEmotion];
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
