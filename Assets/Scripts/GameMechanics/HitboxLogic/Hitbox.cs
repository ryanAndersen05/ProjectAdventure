using UnityEngine;
using System.Collections.Generic;

public class Hitbox : MonoBehaviour {
    public int priority = 0;
    public float damage = 1;
    public List<Hurtbox> allHurtboxes = new List<Hurtbox>();



    void OnEnable()
    {
        refreshHitbox();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Hurtbox hurtBox = collider.GetComponent<Hurtbox>();
        Hitbox hitBox = collider.GetComponent<Hitbox>();

        if (hurtBox != null)
        {
            allHurtboxes.Add(hurtBox);

        }
    }

    void refreshHitbox()
    {
        allHurtboxes.Clear();
    }
}
