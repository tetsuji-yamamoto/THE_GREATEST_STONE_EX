using UnityEngine;

public class PlayerScore : MonoBehaviour {
    public static PlayerScore Instance; // スクリプトが使えるため
    public int currentScore = 0; // 現在スコア

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    public void AddPoints(int points) {
        currentScore += points;
        Debug.Log("ポイントは追加された: " + points);
        Debug.Log("合計: " + currentScore);
    }
}
