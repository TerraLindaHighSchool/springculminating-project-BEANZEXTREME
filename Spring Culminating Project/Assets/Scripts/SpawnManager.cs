﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

   // private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Spawn obstacles
    void SpawnObjects()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(Random.Range(-42, 85), 5, 65);
        int index = Random.Range(0, objectPrefabs.Length);
        /*
        // If game is still active, spawn new object
        if (!playerControllerScript.gameOver)
        {
        */
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        /*
         }
        */
    }
}