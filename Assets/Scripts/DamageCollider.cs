using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    private PlayerLifeDisplay playerLifeDisplay;
    
    void Start()
    {
        playerLifeDisplay = FindObjectOfType<PlayerLifeDisplay>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var attacker = collision.gameObject.GetComponent<Attacker>();
        if (attacker)
        {
            playerLifeDisplay.GetHit();
        }
    }

}
