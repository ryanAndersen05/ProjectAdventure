using UnityEngine;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class DialogueObject : MonoBehaviour {
    public string fileName;
    public DialogueInfo currentDialogueInfo;
    public DialogueInfo resetPoint;

    void Awake()
    {
        
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
                    resetPoint = d;
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

    public void resetDialogue()
    {
        currentDialogueInfo = resetPoint;
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
