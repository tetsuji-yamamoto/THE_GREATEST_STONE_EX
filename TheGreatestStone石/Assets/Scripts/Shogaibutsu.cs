using UnityEngine;

public class Obstacle : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        // �΂ƂԂ��������ǂ���
        if (collision.gameObject.CompareTag("Stone")) {
            // �����_��
            int points = Random.Range(10, 41);

            // �v���C���[�Ƀ|�C���g��n��
            PlayerScore.Instance.AddPoints(points);

            Destroy(gameObject);
        }
    }
}