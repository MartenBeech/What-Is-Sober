using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public static GameObject[] option = new GameObject[2];
    public static string[] optionHidden = new string[2];
    public static int lastClicked = 0;

    private void Start()
    {
        option[0] = GameObject.Find("Option0");
        option[1] = GameObject.Find("Option1");
    }

    public void OptionClicked(int i)
    {
        Player player = new Player();
        if (Misc.phase == "Done")
        {
            player.NewTurn();
        }

        else if (Misc.phase == "ChooseOption")
        {
            lastClicked = i;
            if (Action.currentAction == "Challenge")
            {
                player.NewTurn();
            }

            else if (Action.currentAction == "Treasure")
            {
                if (option[i].GetComponentInChildren<Text>().text == "Lose your Powers")
                {
                    Power.powerUp0[Player.turn].GetComponentInChildren<Text>().text = null;
                    Power.powerUp1[Player.turn].GetComponentInChildren<Text>().text = null;
                }
                else
                {
                    Power power = new Power();
                    power.AddPowerUp(Player.turn, option[i].GetComponentInChildren<Text>().text);
                
                }
                player.NewTurn();
            }

            else if (Action.currentAction == "Boat")
            {
                if (i == 0)
                {
                    Space space = new Space();
                    space.MovePawn(Player.turn, 24, 31);
                    option[0].GetComponentInChildren<Text>().text = "~";
                    option[1].GetComponentInChildren<Text>().text = "~";
                }
                else
                {
                    player.NewTurn();
                }
            }

            else if (Action.currentAction == "DemonDuck")
            {
                if (option[i].GetComponentInChildren<Text>().text == "Move to Star(t)")
                {
                    Space space = new Space();
                    space.MovePawn(Player.turn, 28, 0);
                }
                else
                {
                    if (option[i].GetComponentInChildren<Text>().text == "Lose your Passive effect")
                    {
                        Power.passives[Player.turn].GetComponentInChildren<Text>().text = null;
                    }
                    else
                    {
                        Power.passives[Player.turn].GetComponentInChildren<Text>().text = optionHidden[i];
                        for (int j = 0; j < 6; j++)
                        {
                            if (Player.demonDucked[j])
                            {
                                Power.passives[j].GetComponentInChildren<Text>().text = optionHidden[i];
                            }
                        }
                    }
                    player.NewTurn();
                }
            }

            else if (Action.currentAction == "Star")
            {
                if (option[i].GetComponentInChildren<Text>().text == "Move to the Demon Duck")
                {
                    Space space = new Space();
                    space.MovePawn(Player.turn, 0, 28);
                }
                else
                {
                    if (option[i].GetComponentInChildren<Text>().text == "Lose your Passive effect")
                    {
                        Power.passives[Player.turn].GetComponentInChildren<Text>().text = null;
                    }
                    else
                    {
                        Power.passives[Player.turn].GetComponentInChildren<Text>().text = optionHidden[i];
                        for (int j = 0; j < 6; j++)
                        {
                            if (Player.starred[j])
                            {
                                Power.passives[j].GetComponentInChildren<Text>().text = optionHidden[i];
                            }
                        }
                    }
                    player.NewTurn();
                }
            }
        }
    }
}
