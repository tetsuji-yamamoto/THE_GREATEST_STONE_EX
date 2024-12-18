using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour {
    public TextMeshProUGUI timeText;
    public float limit = 120.0f; // 2 �}�y�~������ �r ���u�{���~�t�p��
    public GameObject text;
    public GameObject player;
    private RestartManager restart;

    void Start() {
        restart = new RestartManager(player, text);
        UpdateTimeText();
    }

    void Update() {
        if (restart.IsGameOver() && Input.GetMouseButton(0)) {
            restart.Restart();
        }

        if (limit <= 0) {
            restart.PrintGameOver();
            return;
        }

        limit -= Time.deltaTime; // �T�}�u�~�����p�u�} ���p�z�}�u��
        UpdateTimeText();
    }

    private void UpdateTimeText() {
        int minutes = Mathf.FloorToInt(limit / 60); // �B�����y���|���u�} �}�y�~������
        int seconds = Mathf.FloorToInt(limit % 60); // �B�����y���|���u�} ���u�{���~�t��
        timeText.text = $"Time Limit: {minutes:D2}:{seconds:D2}"; // �U�����}�p���y�����u�} ���u�{���� (�~�p�����y�}�u��, 02:00)
    }
}
