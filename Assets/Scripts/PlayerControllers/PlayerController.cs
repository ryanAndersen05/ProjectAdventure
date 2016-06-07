using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    JumpMechanics jumpMechanics;
    WalkingMechanics walkMechanics;
    SpriteFlip spriteFlip;

	// Use this for initialization
	void Start () {
        walkMechanics = GetComponent<WalkingMechanics>();
        spriteFlip = GetComponent<SpriteFlip>();
        jumpMechanics = GetComponent<JumpMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        float hInput = Input.GetAxisRaw("Horizontal");
        bool jump = Input.GetButtonDown("Jump");
        walkMechanics.setHInput(hInput);
        spriteFlip.updateIsRight(hInput);
        if (jump)
        {
            jumpMechanics.jump();
        }
	}
}
