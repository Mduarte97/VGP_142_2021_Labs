using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
  
    public GameObject[] spawnObjects;
    public Transform[] spawnLocation;


    // Start is called before the first frame update

    void Start()
    {
        Instantiate(spawnObjects[Random.Range(0, spawnObjects.Length)], spawnLocation[Random.Range(0, spawnLocation.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
