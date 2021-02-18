using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject Boulder;

 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x > -15.5)
        {
            Vector3 move = new Vector3(-1f, 0f, 0f);
            transform.position += move * Time.deltaTime;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x < 9.5)
        {
            Vector3 move = new Vector3(+1f, 0f, 0f);
            transform.position += move * Time.deltaTime;
        }
    }


}

