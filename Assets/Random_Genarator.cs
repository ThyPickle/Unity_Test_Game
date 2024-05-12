using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Genarator : MonoBehaviour
{
    //-------------Left-------------
    public static int OP_door_left;
    public static int ll_plus;
    public static int ll_minus;
    public static int ll_multi;
    public static int ll_divid;
    public static int ll_root;
    public static int ll_power;

    //------------Right-------------
    public static int OP_door_right;
    public static int lr_plus;
    public static int lr_minus;
    public static int lr_multi;
    public static int lr_divid;
    public static int lr_root;
    public static int lr_power;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Spawn_Door.door_decision == true)
        {
            //-------Operation left side--------
            OP_door_left = Random.Range(0, 6);
            //OP_door_left = 5;
            //Debug.Log(OP_door_left);
            ll_plus = Random.Range(1, 21);
            ll_minus = Random.Range(1, 21);
            ll_multi = Random.Range(2, 7);
            ll_divid = Random.Range(2, 10);
            ll_root = 1;
            ll_power = 2;
            //-------Operation right side--------
            OP_door_right = Random.Range(0, 6);
            //OP_door_right = 0;
            //Debug.Log(OP_door_right);
            lr_plus = Random.Range(1, 21);
            lr_minus = Random.Range(1, 21);
            lr_multi = Random.Range(2, 7);
            lr_divid = Random.Range(2, 10);
            lr_root = 1;
            lr_power = 2;
        }
    }
}
