using UnityEngine;
using System.Collections;

public class JumpMechanics : MonoBehaviour
{
    public float jumpForce = 10;
    public bool doubleJumpUsed = false;
    CustomGravity customGravity;
    Rigidbody2D rigid;

    void Start()
    {
        customGravity = GetComponent<CustomGravity>();
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!customGravity.inAir)
        {
            doubleJumpUsed = false;
        }
    }

    public void jump()
    {
        if (!customGravity.inAir)
        {
            jumpPhysics();
            doubleJumpUsed = false;
        }
        else if (!doubleJumpUsed)
        {
            jumpPhysics();
            doubleJumpUsed = true;
        }
    }

    void jumpPhysics()
    {
        rigid.velocity = new Vector2(rigid.velocity.x, 0);
        rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}