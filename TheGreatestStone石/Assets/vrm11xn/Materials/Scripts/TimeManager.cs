using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float limit = 30.0f;
    public GameObject text;
    public GameObject player;
    private RestartManager restart;

    // Start is called before the first frame update
    void Start()
    {
        restart = new RestartManager(player, text);

        timeText.text = "TimeLimit : " + limit + "sec";
    }

    // Update is called once per frame
    void Update()
    {
        if (restart.IsGameOver() && Input.GetMouseButtonDown(0))
		{
            restart.Restart();
		}

        if (limit < 0)
		{
            restart.PrintGameOver();
            return;
		}

        limit -= Time.deltaTime;
        timeText.text = "TimeLimit : " + limit.ToString("f1") + "sec";
    }
}
