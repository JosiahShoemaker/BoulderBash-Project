using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderControl : MonoBehaviour
{

    public GameObject boulder;

    // Update is called once per frame
    void Update()
    {
        //if you press left arrow, spawner moves left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(1, 0, 0);

        }


        //if you press right assrom, spawner moves right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(-1, 0, 0);
        }

        //if you press space, you will create a boulder
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBoulder = Instantiate(boulder);
            newBoulder.transform.position = transform.position;
        }

    }
}