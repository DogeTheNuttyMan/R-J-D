using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] barrierPrefabs;
    private float spawnX = -3;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {

            Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 1, 10);
            int barrierIndex = Random.Range(0, barrierPrefabs.Length);
            Instantiate(barrierPrefabs[barrierIndex], spawnPos, barrierPrefabs[barrierIndex].transform.rotation);
            //Instantiate(barrierPrefabs[barrierIndex], spawnPos, barrierPrefabs[barrierIndex].transform.rotation);
        }



    }
}
