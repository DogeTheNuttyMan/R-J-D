using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject wallPrefab;
    public GameObject tallBarrierPrefab;
    public GameObject barrierPrefab;

    private float startDelay = 2;
    private float repeatDelay = 2;

    private Vector3 wallSpawn = new Vector3(3, 1, 3);
    private Vector3 tallBarrierSpawn = new Vector3(0, 2, 3); 
    private Vector3 barrierSpawn = new Vector3(-3, 1, 3);


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }

    void SpawnObstacle()
    {
        Instantiate(wallPrefab, wallSpawn, wallPrefab.transform.rotation);
        Instantiate(tallBarrierPrefab, tallBarrierSpawn, tallBarrierPrefab.transform.rotation);
        Instantiate(barrierPrefab, barrierSpawn, barrierPrefab.transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
