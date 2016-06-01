using UnityEngine;
using System.Collections;

public class DialogueInfo {
    public string characterName;
    public string dialogueLine;

    public override string ToString()
    {
        return "Character Name: " + characterName + "\nDialogue: " + dialogueLine + "\n" ;
    }
}
