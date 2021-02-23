using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderControl : MonoBehaviour
{

    public GameObject boulder;
    public GameObject spawnedBoulder;

    // Update is called once per frame
    void Update()
    {
        //controlls spawner movement from left to right
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(1f, 0f, 0f);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(-1f, 0f, 0f);
        }

        //when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(spawnedBoulder);
            spawnedBoulder = Instantiate(boulder);
            spawnedBoulder.transform.position = transform.position;
        }

    }
}