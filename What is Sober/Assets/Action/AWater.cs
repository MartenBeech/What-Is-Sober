using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AWater : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action(string player)
    {
        Rng rng = new Rng();

        actions.Add(player + " feels refreshed and gained a power-up:\nIgnore a drink");

        Misc.info.GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];

        Power power = new Power();
        power.AddPowerUp(Player.turn, "Ignore a drink");
    }
}
