using UnityEngine;

public class SkyboxRotator : MonoBehaviour {
    public float rotationSpeed = 10f; // �R�{������������ �r���p���u�~�y�� ���{�p�z�q���{���p

    private void Start() {
        RenderSettings.skybox.SetFloat("_Rotation", 150.0f);
    }

    void Update() {
        // �B�����y���|���u�} �~���r���z ���s���| �r���p���u�~�y��
        float rotation = Time.time * rotationSpeed;

        // �T�����p�~�p�r�|�y�r�p�u�} ���s���| �r���p���u�~�y�� �r �}�p���u���y�p�| ���{�p�z�q���{���p
        RenderSettings.skybox.SetFloat("_Rotation", 150.0f + rotation);
    }
}