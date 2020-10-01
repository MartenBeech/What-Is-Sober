using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static GameObject[] menuPlayers = new GameObject[6];
    public static int playerNmb = 0;
    private GameObject cam;
    private GameObject board;

    private void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            menuPlayers[i] = GameObject.Find("MenuPlayer" + i);
        }

        cam = GameObject.Find("Main Camera");
        board = GameObject.Find("BoardBackground");
    }

    public void StartGameClicked()
    {
        for (int i = 0; i < 6; i++)
        {
            if (menuPlayers[i].GetComponentInChildren<InputField>().text.Length > 0)
            {
                playerNmb++;
                Player.names[i] = "<i>" + menuPlayers[i].GetComponentInChildren<InputField>().text + "</i>";
                Player.players[i].GetComponentInChildren<Text>().text = Player.names[i] + "\n\n" + "<size=18>Space: 0</size>";
            }
            else
            {
                Player.names[i] = null;
                Destroy(Player.players[i]);
                Destroy(Power.powerUp0[i]);
                Destroy(Power.powerUp1[i]);
                Destroy(Power.passives[i]);
                Destroy(Player.pawns[i]);
            }
        }

        if (playerNmb > 0)
        {
            cam.transform.position = new Vector3(board.transform.position.x - 2.15f, board.transform.position.y, -10);
            Player player = new Player();
            player.NewTurn();
        }
    }
}
