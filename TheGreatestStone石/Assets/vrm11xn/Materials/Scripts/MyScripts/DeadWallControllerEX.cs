using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityChan;
using TMPro;

public class DeadWallControllerEX : MonoBehaviour
{
    public float speed = 0.05f;
    public float max_x = 10.0f; // �}�p�{���y�}�p�|���~�p�� �t�y�����p�~���y�� ���� ���y���y�~�u, ���� �{�����������z �}���w�u�� �t�r�y�s�p�������� ���q���u�{��
    public GameObject player;
    public GameObject text;
    bool isGameOver = false;

    private void Update() {
        this.gameObject.transform.Translate(speed, 0, 0);
        var pos = this.gameObject.transform.position;
        if (pos.x > max_x || pos.x < (-max_x)) {
            speed *= -1;
        }

        if (isGameOver && Input.GetMouseButtonDown(0)) {
            Restart();
        }
    }

    private void Restart() {
        Scene loadScene = SceneManager.GetActiveScene(); // �����|�����p�u�} �������|�{�� �~�p ���u�{�������� �p�{���y�r�~���� �����u�~�� �y ���������p�~���u�} �u�v �r ���u���u�}�u�~�~���z loadScene
        SceneManager.LoadScene(loadScene.name); // ���u���u�x�p�s�����w�p�u�} ���u�{�������� �����u�~�� ���� �u�v �y�}�u�~�y.
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == player.name)
        {
            text.GetComponent<TextMeshProUGUI>().text = "Game Over";
            text.SetActive(true);
            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
            player.GetComponent<Animator>().enabled = false;
            isGameOver = true;
        }
    }
}
