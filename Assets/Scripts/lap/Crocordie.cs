using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocordie : Ennamy
{
    [SerializeField]private float attackRange;
    public Player player;

    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;

    //colldown bullet
    [SerializeField] private float bulletSpawnTime;
    [SerializeField] private float bulletTime;

    private void Update()
    {
        bulletTime -= Time.deltaTime;
        Behaviour();
    }

    public override void Behaviour()
    {
        Vector3 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        
        if (distance < attackRange) 
        {
            Shoot();
        
        }

    }
    private void Shoot()
    {
        if (bulletTime <= 0)
        {
            Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);

            bulletTime = bulletSpawnTime;
        }
    
    }
}
