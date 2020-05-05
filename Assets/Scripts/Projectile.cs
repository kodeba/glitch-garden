using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] int damage = 10;
   
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public int GetDamage()
    {
        return damage;
    }

}
