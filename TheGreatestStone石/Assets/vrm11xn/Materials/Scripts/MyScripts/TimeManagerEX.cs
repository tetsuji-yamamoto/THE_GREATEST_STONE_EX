using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManagerEX : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float limit = 30.0f;
    public GameObject text;
    public GameObject player;
    private RestartManagerEX restart;

    void Start() {
        restart = new RestartManagerEX(player, text);
        timeText.text = "Time Limit: " + limit + "sec.";
    }

    void Update() {
        

        if (restart.IsGameOver() && Input.GetMouseButton(0)) {
            restart.Restart();
        }

        if (limit < 0) {
            restart.PrintGameOver();
            return;
        }

        limit -= Time.deltaTime;
        timeText.text = "Time Limit: " + limit.ToString("f1") + " sec.";
    }

}
