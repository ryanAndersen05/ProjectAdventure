using UnityEngine;
using System.Collections.Generic;

public class HitboxManager : MonoBehaviour {
    List<Hitbox> allHitboxes = new List<Hitbox>();
    List<Hurtbox> invalidHurtbox = new List<Hurtbox>();

	// Use this for initialization
	void Start () {
	    foreach (Hitbox h in GetComponentsInChildren<Hitbox>())
        {
            allHitboxes.Add(h);
            h.setHitboxManager(this);
            h.enabled = false;
        }
	}

    public void resetInvalidHurtbox()
    {
        invalidHurtbox.Clear();
    }

    public bool checkIsInvalidHurtbox(Hurtbox hBox)
    {
        return invalidHurtbox.Contains(hBox);
    }
}
