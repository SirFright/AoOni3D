using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnChance : MonoBehaviour
{
    public GameObject oniPrefab;
    bool canSpawn = true;
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        int chanceNum = Random.Range(0, 15);
        Debug.Log(chanceNum);
        if (canSpawn) {
            if (chanceNum == 7) {
                Instantiate(oniPrefab, transform.position, Quaternion.identity);
                canSpawn = false;
            }


        }
    }
}
