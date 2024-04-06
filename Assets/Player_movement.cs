using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{

    public Rigidbody capsule;
    public float goingleft;
    public float goingright;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) == true && Logic_Manager.Player_alive == true)      //When the key A is pressed move to the left side 
        {          
           capsule.velocity = Vector2.left * goingleft;
        }
        if (Input.GetKey(KeyCode.D) == true && Logic_Manager.Player_alive == true)      //When the key D is pressed move to the left side 
        {
            capsule.velocity = Vector2.right * goingright;
        }
    }
}
