using UnityEngine;
using System.Collections;

public class SpriteFlip : MonoBehaviour {
    public bool isRight;
    SpriteRenderer childSprite;

    void Start()
    {
        childSprite = GetComponentInChildren<SpriteRenderer>();

    }

    void Update()
    {
        childSprite.flipX = !isRight;
    }

    public void updateIsRight(float hInput)
    {
        if (hInput > .01f)
        {
            isRight = true;
        }
        if (hInput < -.01f)
        {
            isRight = false;
        }
    }
}
