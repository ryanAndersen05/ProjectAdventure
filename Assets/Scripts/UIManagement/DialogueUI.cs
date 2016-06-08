using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueUI : MonoBehaviour {
    public DialogueObject currentDialogue;
    public Image[] speakers = new Image[2];
    public Text characterName;
    public RectTransform[] characterNamePositions = new RectTransform[2];
    public Text dialogueText;
    public RectTransform backgroundName;

    PortraitUI previousInfo;
    PortraitUI[] currentPortaits = new PortraitUI[2];
    PlayerController playerController;

    // Use this for initialization
    void Awake () {
        playerController = GameObject.FindObjectOfType<PlayerController>();
        gameObject.SetActive(false);
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

    void displayDialogueInfo(int characterSide)
    {
        if (currentDialogue.currentDialogueInfo.characterName == "-End")
        {
            endDialogue();
            return;
        }
        if (currentDialogue.currentDialogueInfo.dialogueLine.Length <= 1)
        {
            displayPortraitImage(characterSide);
            advanceDialogue();
            return;
        }

        displayCharacterName(characterSide);
        dialogueText.text = currentDialogue.currentDialogueInfo.dialogueLine;
        displayPortraitImage(characterSide);
        
    }

    int getCharacterRight()
    {
        for (int i = 0; i < currentPortaits.Length; i++)
        {
            if (currentPortaits[i] == null)
            {

                currentPortaits[i] = CharacterImageManager.getCharacter(currentDialogue.currentDialogueInfo.characterName);
                return i;
            }
            if (currentPortaits[i].characterName == currentDialogue.currentDialogueInfo.characterName)
            {
                currentPortaits[i] = CharacterImageManager.getCharacter(currentDialogue.currentDialogueInfo.characterName);

                return i;
            }

        }
        return 0;
    }

    void displayCharacterName(int characterSide)
    {
        backgroundName.position = characterNamePositions[characterSide].position;
        characterName.text = currentDialogue.currentDialogueInfo.characterName;
    }

    void displayPortraitImage(int characterSide)
    {        
        speakers[characterSide].sprite = CharacterImageManager.getCharacter(currentDialogue.currentDialogueInfo.characterName).emotionPortraits[currentDialogue.currentDialogueInfo.currentEmotion];
    }

    void advanceDialogue()
    {
        currentDialogue.next();
        displayDialogueInfo(getCharacterRight());
    }

    public void startDialogue()
    {
        displayDialogueInfo(getCharacterRight());
        playerController.enabled = false;
        gameObject.SetActive(true);
    }

    public void endDialogue()
    {
        playerController.enabled = true;
        gameObject.SetActive(false);
    }
}
