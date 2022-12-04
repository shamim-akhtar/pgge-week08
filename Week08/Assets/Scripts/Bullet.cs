using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        IDamageable damageableObject = collision.gameObject.GetComponent<IDamageable>();
        if(damageableObject != null)
        {
            damageableObject.TakeDamage();
        }
    }
}
