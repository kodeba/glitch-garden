using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] int minSpawnDelay = 1;

    [SerializeField] int maxSpawnDelay = 5;

    [SerializeField] Attacker attackerPrefab;

    bool isSpawn = true;

    IEnumerator Start()
    {
        while (isSpawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            Instantiate(attackerPrefab, transform.position, Quaternion.identity);
        }
    }

}
