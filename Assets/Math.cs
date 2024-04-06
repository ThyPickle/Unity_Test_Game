using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Math : MonoBehaviour
{
    public static bool Hitright = false;                //Which door is hit
    public static bool Hitleft = false;                 //Which door is hit
    public static int Troop_number_lf = 0;              //Number of troops left
    public static int Troop_number_rg = 0;              //Number of troops right
    public GameObject player;                           //The clone
    private int timer_r = 0;                            //Timer used for deleting troops
    private int timer_l = 0;                            //Timer used for deleting troops
    private float div_number_left = 0;                       //Divider Number left
    private float div_number_right = 0;                       //Divider Number right

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            switch (Random_Genarator.OP_door_left)
            {
                case 0:                         //  +
                    Troop_number_lf = Random_Genarator.ll_plus;
                    if (Hitleft == true)
                    {
                        for (int i = 1; i <= Random_Genarator.ll_plus; i++)                               //Add troops accroding to the positiv_random number (positiv_random gets set in Random_Generator script)
                        {
                            Instantiate(player, transform.position, transform.rotation);
                        }
                        Logic_Manager.Troop_number += Random_Genarator.ll_plus;
                        Hitleft = false;
                    }
                    break;
                case 1:                         //  -
                    Troop_number_lf = Random_Genarator.ll_minus;
                    if (timer_l >= Random_Genarator.ll_minus)
                    {
                        timer_l = 0;
                        Logic_Manager.Troop_number -= Random_Genarator.ll_minus;
                        Hitleft = false;
                    }
                    if (Hitleft == true)
                    {
                        Destroy(GameObject.FindWithTag("Meniec"));                             //Delete troops according to the negativ_random number (negativ_random gets set in Random_Generator script)
                        timer_l++;
                    }
                    break;
                case 2:                         //  *
                    Troop_number_lf = Random_Genarator.ll_multi;
                    if (Hitleft == true)
                    {
                        for(int j = 1; j <= Random_Genarator.ll_multi; j++)
                        {
                            for (int i = 1; i <= Logic_Manager.Troop_number; i++)                               //Add troops accroding to the positiv_random number (positiv_random gets set in Random_Generator script)
                            {
                                Instantiate(player, transform.position, transform.rotation);
                            }
                        }
                        Logic_Manager.Troop_number = Logic_Manager.Troop_number * Random_Genarator.ll_multi;
                        Hitleft = false;
                    }
                break;
                case 3:                         //  :
                    div_number_left = Logic_Manager.Troop_number % Random_Genarator.ll_divid;
                    if(div_number_left != 0)
                    {
                        
                    }
                    else
                    {
                        Troop_number_lf = Random_Genarator.ll_divid;
                        if (timer_l >= (Logic_Manager.Troop_number / Random_Genarator.ll_divid))
                        {
                            timer_l = 0;
                            Logic_Manager.Troop_number = Logic_Manager.Troop_number / Random_Genarator.ll_divid;
                            Hitleft = false;
                        }
                        if (Hitleft == true)
                        {
                            Destroy(GameObject.FindWithTag("Meniec"));                             //Delete troops according to the negativ_random number (negativ_random gets set in Random_Generator script)
                            timer_l++;
                        }
                    }
                break;
                case 4:                         //  fraction
                    
                    break;
                case 5:                         //  root
                    
                    break;
                case 6:                         //  power
                    
                    break;
            }

            switch (Random_Genarator.OP_door_right)
            {
                case 0:                         //  +
                    Troop_number_rg = Random_Genarator.lr_plus;
                    if (Hitright == true)
                    {
                        for (int i = 1; i <= Random_Genarator.lr_plus; i++)                               //Add troops accroding to the positiv_random number (positiv_random gets set in Random_Generator script)
                        {
                            Instantiate(player, transform.position, transform.rotation);
                        }
                        Logic_Manager.Troop_number += Random_Genarator.lr_plus;
                        Hitright = false;
                    }
                    break;
                case 1:                         //  -
                    Troop_number_rg = Random_Genarator.lr_minus;
                    if (timer_r >= Random_Genarator.lr_minus)
                    {
                        timer_r = 0;
                        Logic_Manager.Troop_number -= Random_Genarator.lr_minus;
                        Hitright = false;
                    }
                    if (Hitright == true)
                    {
                        Destroy(GameObject.FindWithTag("Meniec"));                             //Delete troops according to the negativ_random number (negativ_random gets set in Random_Generator script)
                        timer_r++;
                    }
                    break;
                case 2:                         //  *
                    Troop_number_rg = Random_Genarator.lr_multi;
                    if (Hitright == true)
                    {
                        for (int j = 1; j <= Random_Genarator.lr_multi; j++)
                        {
                            for (int i = 1; i <= Logic_Manager.Troop_number; i++)                               //Add troops accroding to the positiv_random number (positiv_random gets set in Random_Generator script)
                            {
                                Instantiate(player, transform.position, transform.rotation);
                            }
                        }
                        Logic_Manager.Troop_number = Logic_Manager.Troop_number * Random_Genarator.lr_multi;
                        Hitright = false;
                    }
                break;
                case 3:                         //  :
                    
                    break;
                case 4:                         //  fraction
                    
                    break;
                case 5:                         //  root
                    
                    break;
                case 6:                         //  power
                    
                    break;
            }
    }
}
