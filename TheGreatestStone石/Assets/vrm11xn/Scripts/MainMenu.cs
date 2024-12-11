using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �q�y�q�|�y�����u�{�p �t�|�� �������p�r�|�u�~�y�� �����u�~�p�}�y (���u���u�����t�� �}�u�w�t�� �������r�~���}�y, �x�p�s�����x�{�p �~���r���� �|���{�p���y�z �y ����)

public class MainMenu : MonoBehaviour {

    public string GameScene; // ������������ ���������{�p �� �y�}�u�~�u�} (�~�p�x�r�p�~�y�u�}). �H�t�u���� �}�� �������u�t�u�|���u�} ������ ���������{��, �������q�� �������q���p�x�y���� �u�v �r �y�~�����u�{�������u, �p ���p�} �}�� �x�p�s�����x�y�} �x�p�}�u������ �~�u�v �~�p���� �y�s�����r���� �����u�~��
    public GameObject mainMenuUI; // �{�~�����{�y �r �s�|�p�r�~���} �}�u�~��

    public void StartGame() {
        SceneManager.LoadScene(GameScene); // �x�t�u���� �}�� ���������y�} �}�u�~�u�t�w�u���p �����u�~ �x�p�s�����x�y���� �~�p���� �����u�~�� (�������r�u�~�� 1)

    }

    public void ExitGame() {
        Debug.Log("Pressed");
        Application.Quit(); // �����~�{���y�� �x�p�{�������y�� �y�s����
    }

}
