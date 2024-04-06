using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Left : MonoBehaviour
{
    public float moveSpeed = 20;                        //How fast the doors move
    public int deadZone = -2;                           //Where the doors get deletet
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.back * moveSpeed) * Time.deltaTime;      //Move the doors to the right position

        if (transform.position.z < deadZone)                                                        //When the door in the dead zone is delete the door
        {
            Destroy(gameObject);
        }
    }
}
