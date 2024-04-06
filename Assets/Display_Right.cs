using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Display_Right : MonoBehaviour
{
    //Define the Texts
    [SerializeField] private TMP_Text Number_right;
    [SerializeField] private string textToDisplay;
    [SerializeField] private TMP_Text Number_left;
    [SerializeField] private string textToDisplay2;

    public void number_Left_plus()                               //Text stats of the left text 
    {
        Number_left.text = ("+"+ Math.Troop_number_lf.ToString());
        Number_left.color = Color.black;
        Number_left.fontSize = 25;
    }

    public void number_Left_minus()                               //Text stats of the left text 
    {
        Number_left.text = (Math.Troop_number_lf * -1).ToString();
        Number_left.color = Color.black;
        Number_left.fontSize = 25;
    }

    public void number_Left_multi()                               //Text stats of the left text 
    {
        Number_left.text = ("*" + Math.Troop_number_lf.ToString());
        Number_left.color = Color.black;
        Number_left.fontSize = 25;
    }

    public void number_Right_plus()                             //Text stats of the right text
    {
        Number_right.text = ("+" + Math.Troop_number_rg.ToString());
        Number_right.color = Color.black;
        Number_right.fontSize = 25;
    }

    public void number_Right_minus()                             //Text stats of the right text
    {
        Number_right.text = (Math.Troop_number_rg * -1).ToString();
        Number_right.color = Color.black;
        Number_right.fontSize = 25;
    }

    public void number_Right_multi()                             //Text stats of the right text
    {
        Number_right.text = ("*" + Math.Troop_number_rg.ToString());
        Number_right.color = Color.black;
        Number_right.fontSize = 25;
    }

    // Start is called before the first frame update
    void Start()
    {
       switch(Random_Genarator.OP_door_left)
       {
            case 0:
                number_Left_plus();
                break; 
            case 1:
                number_Left_minus();
                break;
            case 2:
                number_Left_multi();
                break;

       }
       switch (Random_Genarator.OP_door_right)
       {
            case 0:
                number_Right_plus();
                break;
            case 1:
                number_Right_minus();
                break;
            case 2:
                number_Right_multi();
                break;

       }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
