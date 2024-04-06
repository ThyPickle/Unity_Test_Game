using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Door : MonoBehaviour
{
    public GameObject door;
    public float spawnRate = 2;
    private float timer = 0;
    public float spawnSpeed = 5;
    public static bool door_decision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn the doors in a certain speed
        door_decision = false;
        if (timer < spawnRate)
        {
            timer = timer + (Time.deltaTime * spawnSpeed);
        }
        else
        { 
            Instantiate(door, transform.position, transform.rotation);
            door_decision = true;
            timer = -30;
        }
        //-------------------------------------------------------------
    }
}
