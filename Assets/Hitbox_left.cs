using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox_left : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)          //When a collision between two physical objects happens
    {
        if (collision.gameObject.CompareTag("Enemy Body"))      //When the Player collides with the Hitbox left, set a Bool to true
        {
            Math.Hitleft = true;
            Debug.Log("Hit left");
        }
    }
}
