using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;

    private AttackerSpawner attackerSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("pew pew");
        }
        else
        {
            Debug.Log("sit and wait");
        }
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            var diffY = Mathf.Abs(spawner.transform.position.y - transform.position.y);
            bool isCloseEnough = diffY <= Mathf.Epsilon;
            if (isCloseEnough)
            {
                attackerSpawner = spawner;
                return;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if(attackerSpawner != null)
        {
            return attackerSpawner.transform.childCount > 0;
        }
        else
        {
            return false;
        }
    }

}
