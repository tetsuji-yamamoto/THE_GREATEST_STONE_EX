using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropManagerEX : MonoBehaviour
{
    public GameObject text;
    public GameObject player;
    private RestartManagerEX restart;

    void Start() {
        restart = new RestartManagerEX(player, text);
    }

    void Update() {
        if (player.transform.position.y < -10) { restart.PrintGameOver(); }
        if (restart.IsGameOver() && Input.GetMouseButton(0)) { restart.Restart(); }
    }
}
