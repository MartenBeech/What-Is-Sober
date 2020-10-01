using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ASkull : MonoBehaviour
{
    private List<string> actions = new List<string>();

    public void Action(int roll)
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

        if ((roll >= 1 && roll <= 14) || roll == 20)
        {
            actions.Add("Take 2 sips everytime you make eye contact with another player");
            actions.Add("Take 2 sips everytime you answer any question");
            actions.Add(rndPlayer + " chooses a sound.\nWhenever someone calls out your name, you must make that sound, or take 2 sips");
            actions.Add("You are blind on one eye. Take 2 sips everytime someone points out that both your eyes are open");
            actions.Add("Take the hat off your drink whenever you have to drink, or add 2 sips to it. Don't forget to put the hat back afterwards");
            actions.Add("Whenever someone says your name and you react, take 2 sips");
            actions.Add("You are a simp!\nYou must give a compliment to the opposite gender before you drink, or take 2 sips");
            actions.Add("You have to sing every word that comes out of your mouth, or take 2 sips");
            actions.Add("Sit on the player to the " + (rng.Range(0, 2) == 0 ? "right's" : "left's") + " lap. Take 2 sips every turn you are not lap-sitting");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
            //actions.Add("");
        }

        if (roll >= 2 && roll <= 14)
        {
            Misc.info.GetComponentInChildren<Text>().text = "You are cursed until your next turn:\n" + actions[rng.Range(0, actions.Count)];
        }

        else if (roll == 20)
        {
            Misc.info.GetComponentInChildren<Text>().text = "Everyone else is cursed until your next turn:\n" + actions[rng.Range(0, actions.Count)];
            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 120, 1, 0.5f);
        }

        else if (roll == 1)
        {
            Misc.info.GetComponentInChildren<Text>().text = "You are cursed until you have finished your next full drink:\n" + actions[rng.Range(0, actions.Count)];
            Misc.info.GetComponentInChildren<Text>().color = Color.HSVToRGB((1f / 360) * 0, 1, 0.5f);
        }

        else
        {
            Misc.info.GetComponentInChildren<Text>().text = "You escaped the curse...\nThis time!";
        }
    }
}
