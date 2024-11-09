using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Banana : Weapon
{

    private float speed;
    //public Vector2 MoveDirection = Vector2.right;
   
    public  override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;

    }
    public override void OnHitWith(Character _character)
    {
        if (_character is Ennamy)
            _character.TakeDamage(this.Damage);
    }
    //update move เวลายิง
    private void FixedUpdate()
    {
        Move();
    }
    public void Start()
    {
        Damage = 20;
        speed = 4f * GetShootDiraction();
    }



}
