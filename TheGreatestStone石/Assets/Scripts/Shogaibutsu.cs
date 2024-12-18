using UnityEngine;

public class Obstacle : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        // 石とぶつかったかどうか
        if (collision.gameObject.CompareTag("Stone")) {
            // ランダム
            int points = Random.Range(10, 41);

            // プレイヤーにポイントを渡す
            PlayerScore.Instance.AddPoints(points);

            Destroy(gameObject);
        }
    }
}