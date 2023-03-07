using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthsystem : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <=0 )
        {
            // animator.SetBoolean("IsDead", true);
        }
    }
}
