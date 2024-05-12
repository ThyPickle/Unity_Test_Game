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
    public GameObject Left_root;
    public GameObject Right_root;
    public GameObject Left_expo;
    public GameObject Right_expo;

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
    public void number_Left_div()                               //Text stats of the left text 
    {
        Number_left.text = (":" + Math.Troop_number_lf.ToString());
        Number_left.color = Color.black;
        Number_left.fontSize = 25;
    }

    public void number_Left()                              //Text stats of the left text 
    {
        Number_left.text = Logic_Manager.Troop_number.ToString();
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
    public void number_Right_div()                             //Text stats of the right text
    {
        Number_right.text = (":" + Math.Troop_number_rg.ToString());
        Number_right.color = Color.black;
        Number_right.fontSize = 25;
    }
    public void number_Right()                              //Text stats of the left text 
    {
        Number_right.text = Logic_Manager.Troop_number.ToString();
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
                Left_root.SetActive(false);
                Left_expo.SetActive(false);
                break; 
            case 1:
                number_Left_minus();
                Left_root.SetActive(false);
                Left_expo.SetActive(false);
                break;
            case 2:
                number_Left_multi();
                Left_root.SetActive(false);
                Left_expo.SetActive(false);
                break;
            case 3:
                number_Left_div();
                Left_root.SetActive(false);
                Left_expo.SetActive(false);
                break;
            case 4:
                number_Left();
                Left_root.SetActive(true);
                Left_expo.SetActive(false);
                break;
            case 5:
                number_Left();
                Left_expo.SetActive(true);
                Left_root.SetActive(false);
                break;
       }
       switch (Random_Genarator.OP_door_right)
       {
            case 0:
                number_Right_plus();
                Right_root.SetActive(false);
                Right_expo.SetActive(false);
                break;
            case 1:
                number_Right_minus();
                Right_root.SetActive(false);
                Right_expo.SetActive(false);
                break;
            case 2:
                number_Right_multi();
                Right_root.SetActive(false);
                Right_expo.SetActive(false);
                break;
            case 3:
                number_Right_div();
                Right_root.SetActive(false);
                Right_expo.SetActive(false);
                break;
            case 4:
                number_Right();
                Right_root.SetActive(true);
                Right_expo.SetActive(false);
                break;
            case 5:
                number_Right();
                Right_expo.SetActive(true);
                Right_root.SetActive(false);
                break;
       }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
