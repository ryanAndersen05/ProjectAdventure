using UnityEngine;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class DialogueObject : MonoBehaviour {
    public string fileName;
    public DialogueInfo dialogueHead;

    void Start()
    {
        try
        {
            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            string line = reader.ReadLine();
            DialogueInfo prevDInfo = null;
            while (line != null)
            {
                DialogueInfo d = Dialogue.parseDialogueLine(line);

                if (dialogueHead == null)
                {
                    dialogueHead = d;
                }
                else
                {
                    prevDInfo.addBranch(d);
                }
                prevDInfo = d;
                line = reader.ReadLine();
            }
        } catch
        {
            Debug.Log("The file " + fileName + " is invalid.");
        }
    }

}
