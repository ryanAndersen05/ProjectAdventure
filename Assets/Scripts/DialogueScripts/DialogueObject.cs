using UnityEngine;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class DialogueObject : MonoBehaviour {
    public string fileName;
    DialogueInfo[] allDialogueLines;

    void Start()
    {
        try
        {
            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            string line = reader.ReadLine();
            List<DialogueInfo> allLines = new List<DialogueInfo>();
            while (line != null)
            {
                DialogueInfo d = Dialogue.parseDialogueLine(line);
                allLines.Add(d);
                line = reader.ReadLine();
            }
        } catch
        {

        }
    }

}
