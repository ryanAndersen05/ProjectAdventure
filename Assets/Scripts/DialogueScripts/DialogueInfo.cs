using UnityEngine;
using System.Collections.Generic;

public class DialogueInfo {
    public string characterName;
    public string dialogueLine;
    List<DialogueInfo> branches;

    public override string ToString()
    {
        return "Character Name: " + characterName + "\nDialogue: " + dialogueLine + "\n" ;
    }

    public DialogueInfo getBranch(int i)
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
