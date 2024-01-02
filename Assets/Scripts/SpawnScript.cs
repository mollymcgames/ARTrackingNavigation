using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] gems;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning()); 
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);
        for (int i = 0; i < 3; i++) //change based on number of objects
        {
            Instantiate(gems[i], spawnPoints[i].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }
}
