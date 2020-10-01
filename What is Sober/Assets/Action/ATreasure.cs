using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATreasure : MonoBehaviour
{
    private List<string> powerups = new List<string>();
    private List<string> passives = new List<string>();

    public void Action(int roll)
    {
        Rng rng = new Rng();

        if (roll >= 7 && roll <= 19)
        {
            powerups.Add("Give another player " + rng.Range(2, 6) + " sips");
            powerups.Add("All other players take " + rng.Range(2, 4) + " sips");
            powerups.Add("Add " + rng.Range(2, 6) + " sips to a drink");
            powerups.Add("Subtract " + rng.Range(2, 6) + " sips from a drink");
            powerups.Add("Give another player a shot");
            powerups.Add("Share your drink with a player. Both takes half");
            powerups.Add("'Accidentally' lose half of your drink");
            powerups.Add("Another player has to drink the same as you");
            powerups.Add("If you have 2 powerups; give out " + rng.Range(5, 10) + " sips");
            powerups.Add("Place thumb on table. The last to also do it takes " + rng.Range(2, 6) + " sips");
            powerups.Add("Give a drink with " + rng.Range(2, 6) + " or less sips to another player");
            powerups.Add("Add 1 to ANY diceroll after rolling");
            powerups.Add("Subtract 1 from ANY diceroll after rolling");
            powerups.Add("Automatically roll a 6 on your next d6");


            Misc.info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + ", choose a Power-Up";

            int rnd = rng.Range(0, powerups.Count);
            Option.option[0].GetComponentInChildren<Text>().text = powerups[rnd];
            powerups.RemoveAt(rnd);
            rnd = rng.Range(0, powerups.Count);
            Option.option[1].GetComponentInChildren<Text>().text = powerups[rnd];

            if (Power.powerUp0[Player.turn].GetComponentInChildren<Text>().text != "" && Power.powerUp1[Player.turn].GetComponentInChildren<Text>().text != "")
            {
                Misc.info.GetComponentInChildren<Text>().text = "Too many power-ups! You cannot get any more right now";
                Misc.phase = "Done";
            }
        }

        else if (roll >= 2 && roll <= 6)
        {
            Misc.info.GetComponentInChildren<Text>().text = "The chest was empty...\nTough luck!";
            Misc.phase = "Done";
        }

        else if (roll == 1)
        {
            Misc.info.GetComponentInChildren<Text>().text = "The chest sucks in your Power-ups and then disappeares...\nRude!";
            
            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
            Option.option[0].GetComponentInChildren<Text>().text = "Lose your Powers";
            Option.option[1].GetComponentInChildren<Text>().text = "Lose your Powers";
        }

        else if (roll == 20)
        {
            Misc.info.GetComponentInChildren<Text>().text = Player.names[Player.turn] + ", choose another player by clicking their name.\nSteal their Power-ups";
            Misc.phase = "ChoosePlayer";

            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
            Option.option[0].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
            Option.option[1].GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
        }
    }
}
