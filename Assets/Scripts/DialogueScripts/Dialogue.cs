using UnityEngine;
using System.Collections;

public class Dialogue {
    static int CHARACTER_NAME = 0;
    static int DIALOGUE_LINE = 1;
    static int EMOTION_LINE = 2;


    public static DialogueInfo parseDialogueLine(string dLine)
    {
        DialogueInfo dInfo = new DialogueInfo();
        string[] parsedString = new string[10];
        int i = 0;
        foreach (string s in dLine.Split('|'))
        {
            parsedString[i] = s;
            i++;
        }
        dInfo.characterName = parsedString[CHARACTER_NAME];
        dInfo.dialogueLine = parsedString[DIALOGUE_LINE];
        dInfo.currentEmotion = PortraitUI.emotion2ID(parsedString[EMOTION_LINE]);

        return dInfo;
    }


}
