using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misc : MonoBehaviour
{
    public static GameObject info;
    public static GameObject roll;
    public static string phase = "";
    //Roll6 - Player rolls a d6
    //Roll20 - Player rolls a d20
    //ChoosePlayer - Player chooses another player
    //ChooseOption - Player chooses one of two options
    //Done - When the players have done the actions in real life
    private static string _phase = "";

    private void Start()
    {
        info = GameObject.Find("Info");
        roll = GameObject.Find("Roll");
    }

    private void Update()
    {
        //if (phase != _phase)
        {
            if (phase == "Roll6")
            {
                info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + "\nRoll a d6 to move";
                Option.option[0].GetComponentInChildren<Text>().text = "~";
                Option.option[1].GetComponentInChildren<Text>().text = "~";

                Option.option[0].GetComponentInChildren<Text>().color = Color.black;
                Option.option[1].GetComponentInChildren<Text>().color = Color.black;
                info.GetComponentInChildren<Text>().color = Color.black;
            }

            else if (phase == "Roll20")
            {
                info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + "\nRoll a d20 to determine your luck";
                Option.option[0].GetComponentInChildren<Text>().text = "~";
                Option.option[1].GetComponentInChildren<Text>().text = "~";

                Option.option[0].GetComponentInChildren<Text>().color = Color.black;
                Option.option[1].GetComponentInChildren<Text>().color = Color.black;
                info.GetComponentInChildren<Text>().color = Color.black;
            }

            else if (phase == "Done")
            {
                Option.option[0].GetComponentInChildren<Text>().text = "End Turn";
                Option.option[1].GetComponentInChildren<Text>().text = "End Turn";
            }

            else if (phase == "ChoosePlayer")
            {
                if (Action.currentAction != "Lighthouse" && Action.currentAction != "Treasure")
                {
                    info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + ", choose another player by clicking their name";
                }
            }

            //_phase = phase;
        }
    }


}
