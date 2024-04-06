using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_ground : MonoBehaviour
{
    public GameObject ground;
    public float spawnRate = 2;
    private float timer = 0;
    public float spawnSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawn the ground in a certain speed
        if (timer < spawnRate)
        {
            timer = timer + (Time.deltaTime * spawnSpeed);
        }
        else
        {
            Instantiate(ground, transform.position, transform.rotation);
            timer = -100;
        }
        //---------------------------------------------------------------
    }
}
