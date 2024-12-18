using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartManager : MonoBehaviour {
    private GameObject player;
    private GameObject text;
    private bool isGameOver = false;

    public RestartManager(GameObject player, GameObject text) {
        this.player = player;
        this.text = text;
    }

    public void PrintGameOver() {
        text.GetComponent<TextMeshProUGUI>().text = "Game Over";
        text.SetActive(true);

        isGameOver = true;
    }

    public void Restart() {
        Scene loadScene = SceneManager.GetActiveScene(); // �����|�����p�u�} �������|�{�� �~�p ���u�{�������� �p�{���y�r�~���� �����u�~�� �y ���������p�~���u�} �u�v �r ���u���u�}�u�~�~���z loadScene
        SceneManager.LoadScene(loadScene.name); // ���u���u�x�p�s�����w�p�u�} ���u�{�������� �����u�~�� ���� �u�v �y�}�u�~�y.
    }

    public bool IsGameOver() {
        return isGameOver;
    }
}
