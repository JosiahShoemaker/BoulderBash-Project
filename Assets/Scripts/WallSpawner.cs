using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{

    public GameObject wallPrefab;

    public GameObject spawnedWall;


    // Start is called before the first frame update
    void Start()
    {
        SpawnWall(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SpawnWall();
        }
    }

 
        void SpawnWall()
        {
            //Destroy previous wall
            Destroy(spawnedWall);

            spawnedWall = Instantiate(wallPrefab);
            float randomX = Random.Range(-15.5f, 9.5f);
            spawnedWall.transform.position = new Vector3(randomX, spawnedWall.transform.position.y, spawnedWall.transform.position.z);


        }
    
        
}



