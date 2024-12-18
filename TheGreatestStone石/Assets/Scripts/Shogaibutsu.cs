using UnityEngine;

public class Obstacle : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        // �P�����r�u�����u�}, ������ �������|�{�~���r�u�~�y�u �������y�x�����|�� �� �q���|���w�~�y�{���}
        if (collision.gameObject.CompareTag("Stone")) {
            // �C�u�~�u���p���y�� ���|�����p�z�~���s�� �{���|�y���u�����r�p �����{���r
            int points = Random.Range(10, 41);

            // �D���q�p�r�|���u�} �����{�y �y�s�����{��
            PlayerScore.Instance.AddPoints(points);

            // �Q�p�x�������p�u�} ���q���u�{��
            Destroy(gameObject);
        }
    }
}