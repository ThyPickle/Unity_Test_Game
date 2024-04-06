using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This Script is responsible for the UI and the Game over screen

public class Logic_Manager : MonoBehaviour
{
    public static int Troop_number = 0;
    public Text troopText;
    public GameObject gameOverScreen;
    public static bool Player_alive = true;

    public void Troops()
    {
        troopText.text = Troop_number.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("WOW");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    void Update()
    {
        Troops();
        if(Troop_number < 0)
        {
            gameOver();
            Player_alive = false;
        }
    }
}
