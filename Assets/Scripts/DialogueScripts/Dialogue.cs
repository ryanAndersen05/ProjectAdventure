using UnityEngine;
using System.Collections;

public class Dialogue {
    static int CHARACTER_NAME = 0;
    static int DIALOGUE_LINE = 1;


    public static DialogueInfo parseDialogueLine(string dLine)
    {
        DialogueInfo dInfo = new DialogueInfo();
        string[] parsedString = dLine.Split('|');
        dInfo.characterName = parsedString[CHARACTER_NAME];
        dInfo.dialogueLine = parsedString[DIALOGUE_LINE];

        return dInfo;
    }


}
