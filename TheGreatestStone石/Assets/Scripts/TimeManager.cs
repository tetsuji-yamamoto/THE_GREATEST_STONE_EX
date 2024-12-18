using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour {
    public TextMeshProUGUI timeText;
    public float limit = 120.0f; // 2 Ñ}ÑyÑ~ÑÖÑÑÑç Ñr ÑÉÑuÑ{ÑÖÑ~ÑtÑpÑá
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

        limit -= Time.deltaTime; // ÑTÑ}ÑuÑ~ÑéÑäÑpÑuÑ} ÑÑÑpÑzÑ}ÑuÑÇ
        UpdateTimeText();
    }

    private void UpdateTimeText() {
        int minutes = Mathf.FloorToInt(limit / 60); // ÑBÑçÑâÑyÑÉÑ|ÑëÑuÑ} Ñ}ÑyÑ~ÑÖÑÑÑç
        int seconds = Mathf.FloorToInt(limit % 60); // ÑBÑçÑâÑyÑÉÑ|ÑëÑuÑ} ÑÉÑuÑ{ÑÖÑ~ÑtÑç
        timeText.text = $"Time Limit: {minutes:D2}:{seconds:D2}"; // ÑUÑÄÑÇÑ}ÑpÑÑÑyÑÇÑÖÑuÑ} ÑÑÑuÑ{ÑÉÑÑ (Ñ~ÑpÑÅÑÇÑyÑ}ÑuÑÇ, 02:00)
    }
}
