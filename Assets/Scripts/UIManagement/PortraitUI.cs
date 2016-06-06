using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PortraitUI : MonoBehaviour {
    public const int HAPPY_ID = 0;
    public const int NEUTRAL_ID = 1;
    public const int SAD_ID = 2;
    public const int MAD_ID = 3;

    public Sprite[] emotionPortraits = new Sprite[10];
    public bool isRight = false;

    int currentEmotion = NEUTRAL_ID;
    Animator anim;
    Image currentImage;

    void Start()
    {
        anim = GetComponent<Animator>();
        currentImage = GetComponent<Image>();
        currentImage.sprite = emotionPortraits[currentEmotion];
    }

    

    public void setImage(int id)
    {

    }

    public void setEmotion(int emotionID)
    {
        currentEmotion = emotionID;
    }

    public void setIsRight(bool isRight)
    {
        this.isRight = isRight;
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
            case "Mad":
                return MAD_ID;
            default:
                return -1;
        }
    }
}
