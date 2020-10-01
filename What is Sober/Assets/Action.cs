using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public static string currentAction;
    public static GameObject audio;

    private void Start()
    {
        audio = GameObject.Find("Audio");
    }

    public void TakeAction(int player, int space)
    {
        switch(space)
        {
            case 1:
            case 5:
            case 9:
            case 13:
            case 17:
            case 21:
            case 25:
            case 35:
            case 39:
            case 47:
                currentAction = "Question";
                Misc.phase = "Done";
                AQuestion sleep = new AQuestion();
                sleep.Action();
                break;

            case 2:
            case 6:
            case 10:
            case 14:
            case 18:
            case 22:
            case 27:
            case 29:
            case 32:
            case 36:
            case 48:
                currentAction = "Challenge";
                Misc.phase = "ChoosePlayer";
                break;

            case 3:
            case 7:
            case 11:
            case 15:
            case 19:
            case 23:
            case 33:
            case 37:
            case 45:
            case 49:
                currentAction = "Beer";
                Misc.phase = "Roll20";
                break;

            case 4:
            case 16:
            case 34:
                currentAction = "Gamble";
                Misc.phase = "Done";
                AGamble gamble = new AGamble();
                gamble.Action(Player.names[Player.turn]);
                break;

            case 8:
            case 20:
            case 40:
            case 44:
                currentAction = "Treasure";
                Misc.phase = "Roll20";
                break;

            case 12:
            case 41:
            case 42:
            case 43:
                currentAction = "Water";
                Misc.phase = "Done";
                AWater water = new AWater();
                water.Action(Player.names[Player.turn]);
                break;

            case 24:
                currentAction = "Boat";
                Misc.phase = "ChooseOption";
                ABoat boat = new ABoat();
                boat.Action();
                break;

            case 31:
                currentAction = "Lighthouse";
                Misc.phase = "ChoosePlayer";
                ALighthouse lighthouse = new ALighthouse();
                lighthouse.Action();
                break;

            case 26:
            case 30:
            case 38:
            case 46:
                currentAction = "Skull";
                Misc.phase = "Roll20";
                break;

            case 28:
                currentAction = "DemonDuck";
                Misc.phase = "Roll20";
                break;

            case 0:
                currentAction = "Star";
                Misc.phase = "Roll20";
                break;
        }
        audio.GetComponentInChildren<AudioSource>().clip = Resources.Load<AudioClip>("Sounds/" + currentAction);
        audio.GetComponentInChildren<AudioSource>().Play();
    }
}
