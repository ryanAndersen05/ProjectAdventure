using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public float maxHealth = 100;

    protected float currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
    }

    void takeDamage(float damageTaken, Hurtbox hBox = null)
    {
        if (hBox != null)
        {

        }

        currentHealth -= damageTaken;
        if (currentHealth < 0)
        {
            die();
        }
    }

    protected virtual void die()
    {
        Destroy(this.gameObject);
    }
}
