using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hitbox_right : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)          //When a collision between two physical objects happens
    {
        if (collision.gameObject.CompareTag("Enemy Body2"))     //When the Player collides with the Hitbox right, set a Bool to true
        {
            Math.Hitright = true;
            Debug.Log("Hit right");
        }
    }
}
