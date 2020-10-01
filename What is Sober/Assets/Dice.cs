using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    private int diceRoll = 0;
    public void DiceRolled()
    {
        foreach (char c in Misc.roll.GetComponentInChildren<InputField>().text)
        {
            if (c < '0' || c > '9')
                return;
        }

        diceRoll = int.Parse(Misc.roll.GetComponentInChildren<InputField>().text);
        Misc.roll.GetComponentInChildren<InputField>().text = "";

        if (Misc.phase == "Roll6" && diceRoll >= 1 && diceRoll <= 60)
        {
            Space space = new Space();
            space.MovePawn(Player.turn, Player.tiles[Player.turn], Player.tiles[Player.turn] + diceRoll);
        }

        if (Misc.phase == "Roll20" && diceRoll >= 1 && diceRoll <= 20)
        {
            if (Action.currentAction == "Beer")
            {
                ABeer beer = new ABeer();
                Misc.phase = "Done";
                beer.Action(diceRoll, Player.names[Player.turn]);
            }

            else if (Action.currentAction == "Challenge")
            {
                AChallenge question = new AChallenge();
                Misc.phase = "ChooseOption";
                question.Action(diceRoll);
            }

            else if (Action.currentAction == "Treasure")
            {
                ATreasure treasure = new ATreasure();
                Misc.phase = "ChooseOption";
                treasure.Action(diceRoll);
            }

            else if (Action.currentAction == "Skull")
            {
                ASkull skull = new ASkull();
                Misc.phase = "Done";
                skull.Action(diceRoll);
            }

            else if (Action.currentAction == "DemonDuck")
            {
                ADemonDuck demonDuck = new ADemonDuck();
                Misc.phase = "ChooseOption";
                demonDuck.Action(diceRoll);
            }

            else if (Action.currentAction == "Star")
            {
                AStar star = new AStar();
                Misc.phase = "ChooseOption";
                star.Action(diceRoll);
            }
        }
    }
}
