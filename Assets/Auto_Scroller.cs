using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_Scroller : MonoBehaviour
{
    public float moveSpeed = 5;
    public int deadZone = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.back * moveSpeed) * Time.deltaTime;  //Move the ground to the right position

        if (transform.position.z < deadZone)                                                    //When the ground is in the dead zone delete the ground
        {
            Destroy(gameObject);
        }
    }
}
