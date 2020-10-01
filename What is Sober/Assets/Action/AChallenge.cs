using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AChallenge : MonoBehaviour
{
    private List<string> actions = new List<string>();
    private int sips;

    public void Action(int roll)
    {
        Rng rng = new Rng();

        sips = rng.Range(1, 6);
        actions.Add("Get up and dance like a cowboy");
        actions.Add("Take off one item of clothing");
        actions.Add("Leave the room and reenter, doing a catwalk");
        actions.Add("Truth or dare? Other players agree on one question or dare");
        actions.Add("Propose to the player on your " + (rng.Range(0, 2) == 0 ? "right" : "left"));
        actions.Add("Attempt to do a magic trick");
        actions.Add("Put on a song. Then sing or dance along for at least 20 sec.");
        actions.Add("Let another person draw or write something on you");
        actions.Add("Choose another person to give you a good-old slapping");
        actions.Add("Act out a popular Youtube video for at least 15 sec.");
        actions.Add("Make a funny face until the next player has finished their turn");
        actions.Add("Make a very emotional speech about the player on your " + (rng.Range(0, 2) == 0 ? "right" : "left"));


        if (roll >= 7 && roll <= 19)
        {
            Misc.info.GetComponentInChildren<Text>().text = Player.names[Player.chosenplayer] + ", choose to do a challenge or drink";
            Option.option[0].GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
            Option.option[1].GetComponentInChildren<Text>().text = "Take " + sips + (sips > 1 ? " sips" : " shot");
        }

        else if (roll >= 2 && roll <= 6)
        {
            Misc.info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + ", choose to do a challenge or drink";
            Option.option[0].GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
            Option.option[1].GetComponentInChildren<Text>().text = "Take " + sips + (sips > 1 ? " sips" : " shot");
        }

        else if (roll == 1)
        {
            sips = rng.Range(6, 11);
            Misc.info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + ", choose to do a challenge or drink";
            Option.option[0].GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
            Option.option[1].GetComponentInChildren<Text>().text = "Take " + sips + (sips > 1 ? " sips" : " shot");

            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
            Option.option[0].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
            Option.option[1].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
        }

        else if (roll == 20)
        {
            sips = rng.Range(6, 11);
            Misc.info.GetComponentInChildren<Text>().text = "All other players, choose to do a challenge or drink\n";
            Option.option[0].GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
            Option.option[1].GetComponentInChildren<Text>().text = "Take " + sips + (sips > 1 ? " sips" : " shot");

            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
            Option.option[0].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
            Option.option[1].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
        }
    }
}
