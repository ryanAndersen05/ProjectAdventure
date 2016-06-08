using UnityEngine;
using System.Collections.Generic;

public class DialogueInfo {
    public string characterName;
    public string dialogueLine;
    public int currentEmotion;
    List<DialogueInfo> branches = new List<DialogueInfo>();

    public override string ToString()
    {
        return "Character Name: " + characterName + "\nDialogue: " + dialogueLine + "\nEmotion: " + currentEmotion;
    }

    public DialogueInfo getBranch(int i = 0)
    {
        if (i > branches.Count || i < 0)
        {
            return branches[0];
        }
        return branches[i];
    }

    public void addBranch(DialogueInfo dInfo)
    {
        branches.Add(dInfo);
    }
}
