﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//change name to like move stuffs????
public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
      //  playerControllerScript = GameObject.Find("Character (Swagman)").GetComponent<PlayerController>();
    }

    // Update is called once per frame
  
    void Update()
    {
        //if (playerControllerScript.gameOver == false)
        {
       
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
          /*
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        */
    }
    
}
