using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] int healthPoint = 100;
    float currentSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var projectile = collision.gameObject.GetComponent<Projectile>();
        if (projectile != null)
        {
            healthPoint -= projectile.GetDamage();
            CheckHealth();
        }
    }

    private void CheckHealth()
    {
        if(healthPoint <= 0)
        {
            //TODO: Death Method
        }
    }

}
