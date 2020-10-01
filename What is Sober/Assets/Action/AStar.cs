using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AStar : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action(int roll)
    {
        Rng rng = new Rng();

        Misc.info.GetComponentInChildren<Text>().text = "You found the Golden Star(t). Choose one of its Passive blessings";

        if (roll >= 7 && roll <= 20)
        {
            actions.Add("Your drinks with " + rng.Range(2, 4) + "+ sips contain 1 less");
            actions.Add("Your drinks with " + rng.Range(4, 6) + "+ sips contain 2 less");
            actions.Add("You can turn any shot into 2 sips");
            actions.Add("Choose a player to take 1 sip whenever you drink without them");
            actions.Add("You don't count as a gender");
            actions.Add("Make ANY rule. It lasts until you lose this Passive");
            actions.Add("Your d20 gets +1 when rolling between 2-18");


            int rnd = rng.Range(0, actions.Count);
            Option.optionHidden[0] = actions[rnd];
            actions.RemoveAt(rnd);
            rnd = rng.Range(0, actions.Count);
            Option.optionHidden[1] = actions[rnd];
            Option.option[0].GetComponentInChildren<Text>().text = "Gain a random Star Blessing";
            Option.option[1].GetComponentInChildren<Text>().text = "Gain a random Star Blessing";

            if (roll == 20)
            {
                Misc.info.GetComponentInChildren<Text>().text = "The Golden Star(t) sprinkles its star dust over you.\nFor the rest of the game:\nWhenever someone gets a Star Blessing, you get the same";
                Player.starred[Player.turn] = true;

                Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
                Option.option[0].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
                Option.option[1].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
            }
        }

        else if (roll >= 2 && roll <= 6)
        {
            Misc.info.GetComponentInChildren<Text>().text = "You see the star light slowly dimming...\nAnd so does your Passive effect...\nThat's not nice!";
            Option.option[0].GetComponentInChildren<Text>().text = "Lose your Passive effect";
            Option.option[1].GetComponentInChildren<Text>().text = "Lose your Passive effect";
        }

        else if (roll == 1)
        {
            Misc.info.GetComponentInChildren<Text>().text = "Move to the Demon Duck";
            Option.option[0].GetComponentInChildren<Text>().text = "Move to the Demon Duck";
            Option.option[1].GetComponentInChildren<Text>().text = "Move to the Demon Duck";
            Misc.phase = "ChooseOption";

            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
            Option.option[0].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
            Option.option[1].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
        }
    }
}
