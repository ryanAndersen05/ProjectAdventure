using UnityEngine;
using System.Collections;

public class NPCDialogue : MonoBehaviour {
    DialogueUI dialogueUI;
    DialogueObject dObject;
    bool isActive;

    void Start()
    {
        dialogueUI = GameObject.FindObjectOfType<UIManager>().dialogueUI;
        dObject = GetComponentInChildren<DialogueObject>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        isActive = true;
    }

    void OnTriggerExit2D (Collider2D collider)
    {
        isActive = false;
    }

    void Update()
    {
        if (isActive)
        {
            if (Input.GetButtonDown("Submit"))
            {
                isActive = false;
                dObject.resetDialogue();
                if (dObject.currentDialogueInfo == null)
                {
                    dObject.setUpDialogue();
                }
                dialogueUI.currentDialogue = dObject;
                dialogueUI.startDialogue();
            }
        }
    }
}
