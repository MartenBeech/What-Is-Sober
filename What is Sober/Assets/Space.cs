using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space : MonoBehaviour
{
    public static GameObject[] spaces = new GameObject[50];
    private static float counter = 0f;
    private static int from;
    private static int to;
    private static GameObject pawn;
    private void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            spaces[i] = GameObject.Find("Space" + i);
            spaces[i].GetComponentInChildren<Text>().text = i.ToString();
        }
        spaces[0].GetComponentInChildren<Text>().text = "0/50";
    }

    public void MovePawn(int player, int _from, int _to)
    {
        if (_to >= 50)
        {
            _to -= 50;
        }

        else if (_to < 0)
        {
            _to += 50;
        }
            
        from = _from;
        to = _to;
        pawn = Player.pawns[player];
        Player.tiles[Player.turn] = to;
        counter = 1f;

        if (_from == _to)
        {
            counter = 0.1f;
        }
    }

    private void Update()
    {
        if (counter > 0)
        {
            Vector3 dir = Space.spaces[to].transform.position - Space.spaces[from].transform.position;
            float dist = Mathf.Sqrt(
                Mathf.Pow(Space.spaces[to].transform.position.x - Space.spaces[from].transform.position.x, 2) +
                Mathf.Pow(Space.spaces[to].transform.position.y - Space.spaces[from].transform.position.y, 2));
            pawn.transform.Translate(dir.normalized * dist * Time.deltaTime);
            counter -= Time.deltaTime;

            if (counter <= 0)
            {
                Player.players[Player.turn].GetComponentInChildren<Text>().text = Player.names[Player.turn] + "\n\n" + "Space: " + to;
                Action action = new Action();
                action.TakeAction(Player.turn, to);
            }
        }
    }
}
