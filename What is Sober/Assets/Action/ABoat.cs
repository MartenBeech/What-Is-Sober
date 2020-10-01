using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABoat : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action()
    {
        Rng rng = new Rng();

        Misc.info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + ", you can either take the boat (by impressing the captain) or do nothing";

        int sips = rng.Range(1, 10);
        actions.Add("Take " + sips + (sips > 1 ? " sips" : " shot") + " and move to the Lighthouse");


        Option.option[0].GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
        Option.option[1].GetComponentInChildren<Text>().text = "End Turn";
    }
}
