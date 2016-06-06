using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PortraitUI : MonoBehaviour {
    public const int HAPPY_ID = 0;
    public const int NEUTRAL_ID = 1;
    public const int SAD_ID = 2;

    public Image[] emotionPortraits = new Image[10];
    int currentEmotion = NEUTRAL_ID;
    public bool isRight = false;

    

    public void setImage(int id, bool isRight)
    {

    }

    public static int emotion2ID(string emotionName)
    {
        switch (emotionName)
        {
            case "Happy":
                return HAPPY_ID;
            case "Neutral":
                return NEUTRAL_ID;
            case "Sad":
                return SAD_ID;
            default:
                return -1;
        }
    }
}
