using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitControllerEX : MonoBehaviour
{
    public GameObject player;
    public GameObject text;
    private RestartManagerEX restart;

    void Start()
    {
        restart = new RestartManagerEX(player, text);
    }

    // Update is called once per frame
    void Update()
    {
        if (restart.IsGameOver() && Input.GetMouseButtonDown(0)) { restart.Restart(); }


    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == player.name) {
            restart.PrintGameOver();
        }
    }
}
