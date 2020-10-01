using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AGamble : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action(string player)
    {
        Rng rng = new Rng();

        int sips = rng.Range(1, 7);
        int table = rng.Range(6, 10);
        actions.Add(player + ", choose a category.\nTake turns naming things inside that category until someone loses.\nThe loser takes " + sips + (sips > 1 ? " sips" : " shot"));
        actions.Add("Take turns counting up from 1. Say BOOM instead of every " + table + "th number, as well as any number containing " + table + ".\n" + player + " starts.\nThe loser takes " + sips + (sips > 1 ? " sips" : " shot") + ".\n" + player + " starts");
        actions.Add("WATERFALL!\n" + player + ", drink for as long as you like. All other players can't stop drinking until their previous player has stopped");
        actions.Add(player + ", choose a singer/group/band.\nTake turns naming one of their songs until someone loses.\nThe loser takes " + sips + (sips > 1 ? " sips" : " shot"));
        actions.Add("Never have I ever!\nTake turns saying something you have never done. Anyone who has done it takes 2 sips.\n" + player + " starts");
        actions.Add(player + ", choose a word.\nTake turns saying a word related to the word the previous player said. If you can't come up with anything within 2 seconds, take " + sips + (sips > 1 ? " sips" : " shot"));
        actions.Add(player + ", finish the sentence;\n<b>'Fun things to do when...'</b>.\nTake turns coming up with things relating to the sentence. The first to run out of ideas takes " + sips + (sips > 1 ? " sips" : " shot") + ".\n" + player + " starts");
        //actions.Add("");
        //actions.Add("");
        //actions.Add("");
        //actions.Add("");
        //actions.Add("");
        //actions.Add("");
        //actions.Add("");
        //actions.Add("");
        //actions.Add("");

        Misc.info.GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
    }
}
