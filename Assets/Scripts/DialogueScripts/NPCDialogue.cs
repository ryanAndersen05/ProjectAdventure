using UnityEngine;
using System.Collections;

public class NPCDialogue : MonoBehaviour {
    DialogueUI dialogueUI;
    DialogueObject dObject;
    PlayerController playerController;
    bool isActive;

    void Start()
    {
        dialogueUI = GameObject.FindObjectOfType<UIManager>().dialogueUI;
        dObject = GetComponentInChildren<DialogueObject>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerController p = collider.GetComponent<PlayerController>();
        if (p != null)
        {
            isActive = true;
            playerController = p;
        }
    }

    void OnTriggerExit2D (Collider2D collider)
    {
        PlayerController p = collider.GetComponent<PlayerController>();
        if (p != null)
        {
            
            isActive = false;
        }
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
