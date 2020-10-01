using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ALighthouse : MonoBehaviour
{
    private List<string> actions = new List<string>();
    public static int rndSpaces;

    public void Action()
    {
        Rng rng = new Rng();

        rndSpaces = rng.Range(-3, 4);
        actions.Add(Player.names[Player.turn] + ", choose another player by clicking their name.\nThat player moves " + (rndSpaces >= 0 ? rndSpaces + " spaces forwards" : -rndSpaces + " spaces backwards") + " and takes the action.\nIt's now that player's turn");


        Misc.info.GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
    }
}
