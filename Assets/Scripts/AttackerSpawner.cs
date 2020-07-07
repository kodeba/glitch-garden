using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] int minSpawnDelay = 1;

    [SerializeField] int maxSpawnDelay = 5;

    [SerializeField] Attacker[] attackerPrefabs;

    bool isSpawn = true;

    IEnumerator Start()
    {
        while (isSpawn)
        {
            int attackerIndex = Random.Range(0, attackerPrefabs.Length);
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            var attacker = Instantiate(attackerPrefabs[attackerIndex], transform.position, Quaternion.identity) as Attacker;
            attacker.transform.parent = transform;
            if (FindObjectOfType<LevelControl>().IsLevelTimerFinised())
            {
                isSpawn = false;
            }
        }
    }

}
