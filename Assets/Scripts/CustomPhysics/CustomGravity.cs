using UnityEngine;
using System.Collections;

public class CustomGravity : MonoBehaviour {
    public const float gravity = 9.81f;
    public float maxVelocity = -6;
    public float gravityScale = 1;
    public float weight = 50;
    public float fastFallScale = 2;

    public bool inAir;

    Rigidbody2D rigid;
    float vInput;
    bool highJumpDown;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
    }

	void FixedUpdate()
    {
        float goalY = maxVelocity;
        float acceleration = Time.fixedDeltaTime * gravity * gravityScale;
        if (highJumpDown)
        {
            acceleration /= 1.5f;
        }
        if (vInput < -.25f)
        {
            acceleration *= fastFallScale;
        }
        if (vInput > .25f)
        {
            acceleration /= 1.25f;
        }
        float newYVelocity = Mathf.MoveTowards(rigid.velocity.y, goalY, acceleration);
        rigid.velocity = new Vector2(rigid.velocity.x, newYVelocity);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        inAir = false;
    }

    public void setVInput(float vInput)
    {
        this.vInput = vInput;
    }

    public void setHighJumpDown(bool highJump)
    {
        this.highJumpDown = highJump;
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        inAir = true;
    }
}
