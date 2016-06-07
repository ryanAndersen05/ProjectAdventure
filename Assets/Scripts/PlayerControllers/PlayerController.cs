using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    WalkingMechanics walkMechanics;
    SpriteFlip spriteFlip;

	// Use this for initialization
	void Start () {
        walkMechanics = GetComponent<WalkingMechanics>();
        spriteFlip = GetComponent<SpriteFlip>();
	}
	
	// Update is called once per frame
	void Update () {
        float hInput = Input.GetAxisRaw("Horizontal");
        walkMechanics.setHInput(hInput);
        spriteFlip.updateIsRight(hInput);
	}
}
