using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set 
        { 
           health = value;
        }
    }

    [SerializeField] hpdown hpdown; 
    public Animator anim;
    public Rigidbody2D rb;

    //method

    public bool IsDead()
    {
        return Health <= 0;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        hpdown.UpdateHealthBar(Health);
        Debug.Log($"{health}");
    }
    public void InIt(int newHealth)
    { 
        Health = newHealth;
        hpdown.SetMaxHP(Health);
        hpdown.UpdateHealthBar(Health);
    
    }

}
