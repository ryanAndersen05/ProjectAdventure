using UnityEngine;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class DialogueObject : MonoBehaviour {
    public string fileName;
    public DialogueInfo currentDialogueInfo;

    void Awake()
    {
        setUpDialogue();
        print("I did the thing");
    }

    public DialogueInfo setUpDialogue()
    {
        try
        {
            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            string line = reader.ReadLine();
            DialogueInfo prevDInfo = null;
            while (line != null)
            {
                DialogueInfo d = Dialogue.parseDialogueLine(line);

                if (currentDialogueInfo == null)
                {
                    currentDialogueInfo = d;
                }
                else
                {
                    prevDInfo.addBranch(d);
                }
                prevDInfo = d;
                line = reader.ReadLine();
            }
        }
        catch
        {
            Debug.Log("The file " + fileName + " is invalid.");
        }
        return currentDialogueInfo;
    }

    public DialogueInfo getDialogueInfo()
    {
        return currentDialogueInfo;
    }

    public void next(int i = 0)
    {
        currentDialogueInfo = currentDialogueInfo.getBranch(i); 
    }

}
