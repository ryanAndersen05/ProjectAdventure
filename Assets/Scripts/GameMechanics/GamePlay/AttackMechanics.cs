using UnityEngine;
using System.Collections;

public class AttackMechanics : MonoBehaviour {

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public void attack(bool attackButton)
    {
        if (attackButton)
        {
            anim.SetTrigger("Attack");
        }
    }
}
