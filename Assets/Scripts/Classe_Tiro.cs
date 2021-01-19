using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classe_Tiro : MonoBehaviour
{

    float BulletDamage;
    float BulletSpeed;
    float MaxDistanceBullet;
    GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        BulletDamage = 1;
        BulletSpeed = 220;
        MaxDistanceBullet = 30;
    }

    private void FixedUpdate()
    {
        Move();
        checkDistance(parent);
    }

    public void Move()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * GetSpeed() * Time.deltaTime, ForceMode.Impulse);
    }


    public void checkDistance(GameObject player)
    {
        if(Vector3.Distance(transform.position,player.transform.position)> MaxDistanceBullet)
        {
            Destroy(gameObject);
        }
    }


    public void ApplyDamage(float Damage,GameObject Hitted)
    {
        //get object life status and apply damage based on the damage the bullet does
        Destroy(gameObject);
    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject ObjectHitted = collision.gameObject;
        ApplyDamage(BulletDamage,ObjectHitted);
    }

    public float GetSpeed()
    {
    
        return BulletSpeed;
    }
    public void setParent(GameObject parente)
    {
        parent = parente;
    }

    public void setMaxDistanceBullet(float newDistance)
    {
        MaxDistanceBullet = newDistance;
    }
    public void AddMaxDistanceBullet(float newDistance)
    {
        MaxDistanceBullet += newDistance;
    }
    public float getMaxDistance()
    {
        return MaxDistanceBullet;
    }
}
