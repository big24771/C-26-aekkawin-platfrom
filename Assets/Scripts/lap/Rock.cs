using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private Vector2 force;
    public override void Move()
    { 
        rb.AddForce(force, ForceMode2D.Impulse);
    
    }
    public override void OnHitWith(Character character)
    {
        if (character is Player)
            character.TakeDamage(this.Damage);
    }

    public void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        Damage = 20;
        force = new Vector2(GetShootDiraction() * 5, 10);
        Move();
    
    
    }
    void Update() 
    {
        
    
    
    
    }


}
