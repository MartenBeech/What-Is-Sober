using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static GameObject[] pawns = new GameObject[6];
    public static GameObject[] players = new GameObject[6];
    public static int turn = -1;
    public static int[] tiles = new int[6];
    public static string[] names = new string[6];
    public static int chosenplayer = -1;
    public static bool[] demonDucked = new bool[6];
    public static bool[] starred = new bool[6];

    private void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            players[i] = GameObject.Find("Player" + i);
        }

        pawns[0] = GameObject.Find("PawnBlue");
        pawns[1] = GameObject.Find("PawnGreen");
        pawns[2] = GameObject.Find("PawnPink");
        pawns[3] = GameObject.Find("PawnRed");
        pawns[4] = GameObject.Find("PawnTeal");
        pawns[5] = GameObject.Find("PawnYellow");

        for (int i = 0; i < 6; i++)
        {
            tiles[i] = 0;
            demonDucked[i] = false;
            starred[i] = false;
        }
    }

    public void NewTurn()
    {
        do
        {
            turn++;
            if (turn == 6)
            {
                turn = 0;
            }
        } while (names[turn] == null);

        Misc.phase = "Roll6";
    }

    public void ChoosePlayer(int i)
    {
        if (Misc.phase == "ChoosePlayer")
        {
            chosenplayer = i;

            if (Action.currentAction == "Challenge")
            {
                Misc.phase = "Roll20";
            }

            else if (Action.currentAction == "Lighthouse")
            {
                turn = chosenplayer;
                Space space = new Space();
                space.MovePawn(chosenplayer, tiles[chosenplayer], tiles[chosenplayer] + ALighthouse.rndSpaces);
            }

            else if (Action.currentAction == "Treasure")
            {
                Power power = new Power();
                if (Power.powerUp0[i].GetComponentInChildren<Text>().text != null && Power.powerUp0[i].GetComponentInChildren<Text>().text != "")
                {
                    power.AddPowerUp(Player.turn, Power.powerUp0[i].GetComponentInChildren<Text>().text);
                }
                if (Power.powerUp1[i].GetComponentInChildren<Text>().text != null && Power.powerUp1[i].GetComponentInChildren<Text>().text != "")
                {
                    power.AddPowerUp(Player.turn, Power.powerUp1[i].GetComponentInChildren<Text>().text);
                }

                Power.powerUp0[i].GetComponentInChildren<Text>().text = null;
                Power.powerUp1[i].GetComponentInChildren<Text>().text = null;
                Player player = new Player();
                player.NewTurn();
            }
        }
    }
}
