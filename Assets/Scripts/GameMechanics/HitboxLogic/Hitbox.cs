using UnityEngine;
using System.Collections.Generic;

public class Hitbox : MonoBehaviour {
    public int priority = 0;
    public float damage = 1;

    HitboxManager hitManager;

    void OnEnable()
    {
        refreshHitbox();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Hurtbox hurtBox = collider.GetComponent<Hurtbox>();
        Hitbox hitBox = collider.GetComponent<Hitbox>();
        if (hitBox != null)
        {
            if (hitBox.priority == priority)
            {
                clankHitbox();
                return;
            }
            if (hitBox.priority > priority)
            {
                return;
            }
            if (hitBox.priority < priority)
            {
                return;
            }
        }
        if (hurtBox != null)
        {
            attackHurtbox(hurtBox);
        }

    }

    protected virtual void attackHurtbox(Hurtbox hBox)
    {
        
    }



    void clankHitbox()
    {

    }

    void refreshHitbox()
    {
    }

    public void setHitboxManager(HitboxManager hManager)
    {
        this.hitManager = hManager;
    }
}
