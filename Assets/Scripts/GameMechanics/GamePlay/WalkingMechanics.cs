using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class WalkingMechanics : MonoBehaviour {
    public float maxSpeed = 5;
    public float acceleration = 15;

    Rigidbody2D rigid;
    Animator anim;
    protected float hInput;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector2 goalVelocity = new Vector2(hInput * maxSpeed, rigid.velocity.y);
        rigid.velocity = Vector2.MoveTowards(rigid.velocity, goalVelocity, acceleration * Time.fixedDeltaTime);
        anim.SetFloat("Speed", Mathf.Abs(hInput));
    }

    public void setHInput(float hInput)
    {
        this.hInput = hInput;
    }
}
