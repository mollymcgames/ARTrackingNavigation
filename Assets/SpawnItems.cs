using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] gems;

    private bool hasSpawned = false; //check if the gem has spawned yet
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning()); 
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);
        if (!hasSpawned)
        {
            for (int i = 0; i < 5; i++) //change based on number of objects
            {
                // Instantiate(gems[i], spawnPoints[i].position, Quaternion.identity);
                Instantiate(gems[i], new Vector3(spawnPoints[i].position.x, spawnPoints[i].position.y, 1.5f), Quaternion.identity);
            }
            hasSpawned = true;
        }
    }
}
