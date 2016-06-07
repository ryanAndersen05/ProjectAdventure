using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class WalkingMechanics : MonoBehaviour {
    public float maxSpeed = 5;
    public float acceleration = 15;

    Rigidbody2D rigid;
    protected float hInput;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 goalVelocity = new Vector2(hInput * maxSpeed, rigid.velocity.y);
        rigid.velocity = Vector2.MoveTowards(rigid.velocity, goalVelocity, acceleration * Time.fixedDeltaTime);
    }

    void updateWalkSpeed()
    {

    }

    public void setHInput(float hInput)
    {
        this.hInput = hInput;
    }
}
