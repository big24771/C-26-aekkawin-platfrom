using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] public string  Ishootable;
    
    [SerializeField]private int damage;
    public Ishootable shooter;

    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;

        }
    }

    public abstract void OnHitWith(Character _character);
    public abstract void Move();
    public void Init(int _damage, Ishootable _owner)
    {
        damage = _damage;
        shooter = _owner;
    
    
    
    }
    
    public int GetShootDiraction()
    {
        float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if(shootDir > 0)
        return 1;
        else return -1;
    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Character>();//àªç¤ª¹
        //Destroy(this.gameObject, 6f); 
    }


}
