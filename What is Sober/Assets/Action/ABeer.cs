using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ABeer : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action(int roll, string player)
    {
        Rng rng = new Rng();

        List<string> players = new List<string>();
        for (int i = 0; i < 6; i++)
        {
            if (Player.names[i] != null && i != Player.turn)
            {
                players.Add(Player.names[i]);
            }
        }
        string rndPlayer = players[rng.Range(0, players.Count)];

        if (roll >= 12 && roll <= 19)
        {
            actions.Add(player + "\nTake " + rng.Range(1, 4) + " sips. Everyone else takes double as many");
            actions.Add(player + "\nTake 1 sip. The next player takes 2 sips. The next again takes 3, etc.");
            actions.Add(player + "\nGive " + rng.Range(2, 5) + " sips to two players each");
            actions.Add(player + "\nGive " + rng.Range(1, 4) + " sips to as many players you want to");
            actions.Add(player + "\nGive out " + rng.Range(4, 8) + " sips");
            actions.Add(player + "\nGive a shot to another player");
            actions.Add(player + "\nGive out sips equal to the current weekday\n(Monday = 1-day, Tuesday = 2s-day etc.)");
            actions.Add(player + "\nGive " + rng.Range(2, 5) + " sips to both your neighbors");

            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
        }

        else if (roll >= 6 && roll <= 11)
        {
            actions.Add(rndPlayer + " thinks all girls should drink.\nTake " + rng.Range(2, 5) + " sips each.\nCheers, ladies!");
            actions.Add(rndPlayer + " thinks all girls should drink.\nTake " + rng.Range(2, 5) + " sips each.\nCheers, ladies!");
            actions.Add(rndPlayer + " thinks all girls should take 1 shot. Better do it");

            actions.Add(rndPlayer + " thinks all boys should drink.\nTake " + rng.Range(2, 5) + " sips each.\nCheers, guys!");
            actions.Add(rndPlayer + " thinks all boys should drink.\nTake " + rng.Range(2, 5) + " sips each.\nCheers, guys!");
            actions.Add(rndPlayer + " thinks all boys should take 1 shot. Better do it");

            actions.Add(rndPlayer + " yelled CHEERS!\nEveryone takes " + rng.Range(2, 5) + " sips");
            actions.Add(rndPlayer + " called out for SHOOOOTS!\nEveryone takes 1 shot");
        }

        else if (roll >= 2 && roll <= 5)
        {
            actions.Add(player + "\nAll other players take " + rng.Range(1, 4) + " sips. You take double as many");
            actions.Add(player + "\nTake sips equal to the number of players. The next player takes 1 less. The next again takes 2 less, etc.");
            actions.Add(player + "\nAll other players give you 1 sip each");
            actions.Add(player + "\nTake a shot");
        }

        else if (roll == 1)
        {
            actions.Add(player + "\nDown your drink or take " + rng.Range(2, 4) + " shots");

            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
        }

        else if (roll == 20)
        {
            actions.Add(player + "\nChoose another player.\nThey will choose to down their drink or take " + rng.Range(2, 4) + " shots");

            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
        }

        Misc.info.GetComponentInChildren<Text>().text = actions[rng.Range(0, actions.Count)];
    }
}
