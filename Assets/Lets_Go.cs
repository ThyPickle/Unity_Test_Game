using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lets_Go : MonoBehaviour
{
    public GameObject Gamer;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Gamer, transform.position, transform.rotation); //Spawn the player
    }

    // Update is called once per frame
    void Update()
    {       
             
    }
}
