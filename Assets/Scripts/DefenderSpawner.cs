using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Spawn();
    }

    private void Spawn()
    {
        Instantiate(defender, transform.position, Quaternion.identity);
    }

}
