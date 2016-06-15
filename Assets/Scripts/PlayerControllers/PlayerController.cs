using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    JumpMechanics jumpMechanics;
    WalkingMechanics walkMechanics;
    CustomGravity customGravity;
    SpriteFlip spriteFlip;
    AttackMechanics attackMechanics;

	// Use this for initialization
	void Start () {
        walkMechanics = GetComponent<WalkingMechanics>();
        spriteFlip = GetComponent<SpriteFlip>();
        jumpMechanics = GetComponent<JumpMechanics>();
        customGravity = GetComponent<CustomGravity>();
        attackMechanics = GetComponent<AttackMechanics>();
	}
	
	// Update is called once per frame
	void Update () {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");
        bool jump = Input.GetButtonDown("Jump");
        bool attack = Input.GetButtonDown("Attack");

        walkMechanics.setHInput(hInput);
        spriteFlip.updateIsRight(hInput);
        if (jump)
        {
            jumpMechanics.jump();
        }
        attackMechanics.attack(attack);
        customGravity.setHighJumpDown(jump);
        customGravity.setVInput(vInput);
	}
}
