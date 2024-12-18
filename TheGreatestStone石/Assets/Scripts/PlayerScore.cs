using UnityEngine;

public class PlayerScore : MonoBehaviour {
    public static PlayerScore Instance; // �X�N���v�g���g���邽��
    public int currentScore = 0; // ���݃X�R�A

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void AddPoints(int points) {
        currentScore += points;
        Debug.Log("�|�C���g�͒ǉ����ꂽ: " + points);
        Debug.Log("���v: " + currentScore);
    }
}
