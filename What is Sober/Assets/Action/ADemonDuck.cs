using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ADemonDuck : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action(int roll)
    {
        Rng rng = new Rng();

        Misc.info.GetComponentInChildren<Text>().text = "You made a deal with the Demon Duck. Choose one of its Passive conditions";

        if (roll >= 15 && roll <= 19)
        {
            Misc.info.GetComponentInChildren<Text>().text = "The Demon Duck allows you to leave...\nBut it keeps your Passive effect...\nDon't come back!";
            Option.option[0].GetComponentInChildren<Text>().text = "Lose your Passive effect";
            Option.option[1].GetComponentInChildren<Text>().text = "Lose your Passive effect";
        }

        else if (roll >= 1 && roll <= 14)
        {
            actions.Add("You are all genders");
            actions.Add("Your drinks with " + rng.Range(3, 5) + " or less sips contain 1 more");
            actions.Add("Your drinks with exactly " + rng.Range(1, 4) + " sip(s) contain 2 more");
            actions.Add("Choose a player. You take 1 sip whenever they drink without you");
            actions.Add("Your d20 gets -1 when rolling between 3-19");


            int rnd = rng.Range(0, actions.Count);
            Option.optionHidden[0] = actions[rnd];
            actions.RemoveAt(rnd);
            rnd = rng.Range(0, actions.Count);
            Option.optionHidden[1] = actions[rnd];
            Option.option[0].GetComponentInChildren<Text>().text = "Gain a random Demon Duck Deal";
            Option.option[1].GetComponentInChildren<Text>().text = "Gain a random Demon Duck Deal";

            if (roll == 1)
            {
                Misc.info.GetComponentInChildren<Text>().text = "You sold your soul to the Demon Duck.\nFor the rest of the game:\nWhenever someone gets a Demon Duck Deal, you get the same";
                Player.demonDucked[Player.turn] = true;

                Option.option[0].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
                Option.option[1].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
                Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
            }
        }

        else if (roll == 20)
        {
            Misc.info.GetComponentInChildren<Text>().text = "Move to Star(t)";
            Option.option[0].GetComponentInChildren<Text>().text = "Move to Star(t)";
            Option.option[1].GetComponentInChildren<Text>().text = "Move to Star(t)";
            Misc.phase = "ChooseOption";

            Option.option[0].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
            Option.option[1].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
        }
    }
}
