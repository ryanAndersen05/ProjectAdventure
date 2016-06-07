using UnityEngine;
using System.Collections;

public class CustomGravity : MonoBehaviour {
    public const float gravity = 9.81f;
    public float maxVelocity = -6;
    public float gravityScale = 1;
    public float weight = 50;

    public bool inAir;

    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
    }

	void FixedUpdate()
    {
        float goalY = maxVelocity;
        float newYVelocity = Mathf.MoveTowards(rigid.velocity.y, goalY, Time.fixedDeltaTime * gravity * gravityScale);
        rigid.velocity = new Vector2(rigid.velocity.x, newYVelocity);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        
        inAir = false;
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        inAir = true;
    }
}
