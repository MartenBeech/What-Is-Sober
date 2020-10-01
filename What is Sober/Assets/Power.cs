using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    public static GameObject[] powerUp0 = new GameObject[6];
    public static GameObject[] powerUp1 = new GameObject[6];
    public static GameObject[] passives = new GameObject[6];

    private void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            powerUp0[i] = GameObject.Find("Player" + i + "Treasure0");
            powerUp1[i] = GameObject.Find("Player" + i + "Treasure1");
            passives[i] = GameObject.Find("Player" + i + "Treasure2");
        }
    }

    public void AddPowerUp(int player, string power)
    {
        if (powerUp0[player].GetComponentInChildren<Text>().text == "")
        {
            powerUp0[player].GetComponentInChildren<Text>().text = power;
        }

        else if (powerUp1[player].GetComponentInChildren<Text>().text == "")
        {
            powerUp1[player].GetComponentInChildren<Text>().text = power;
        }
    }

    public void PowerUpClicked(int powerUp)
    {
        if (powerUp == 0)
            powerUp0[0].GetComponentInChildren<Text>().text = "";
        else if (powerUp == 1)
            powerUp1[0].GetComponentInChildren<Text>().text = "";

        else if (powerUp == 2)
            powerUp0[1].GetComponentInChildren<Text>().text = "";
        else if (powerUp == 3)
            powerUp1[1].GetComponentInChildren<Text>().text = "";

        else if (powerUp == 4)
            powerUp0[2].GetComponentInChildren<Text>().text = "";
        else if (powerUp == 5)
            powerUp1[2].GetComponentInChildren<Text>().text = "";

        else if (powerUp == 6)
            powerUp0[3].GetComponentInChildren<Text>().text = "";
        else if (powerUp == 7)
            powerUp1[3].GetComponentInChildren<Text>().text = "";

        else if (powerUp == 8)
            powerUp0[4].GetComponentInChildren<Text>().text = "";
        else if (powerUp == 9)
            powerUp1[4].GetComponentInChildren<Text>().text = "";

        else if (powerUp == 10)
            powerUp0[5].GetComponentInChildren<Text>().text = "";
        else if (powerUp == 11)
            powerUp1[5].GetComponentInChildren<Text>().text = "";
    }
}
