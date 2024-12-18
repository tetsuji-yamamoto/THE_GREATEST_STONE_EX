using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeMa : MonoBehaviour
{
    public TextMeshProUGUI timeText; // ���ԕ\���p�e�L�X�g
    public float Timer = 0.0f;       // ���Ԃ�ۑ�
    public GameObject player;        // �v���C���[���i�[����ϐ�
    public GameObject text;          // �e�L�X�g���i�[����ϐ�

    // Start is called before the first frame update
    void Start()
    {
        // �C���X�^���X����
        timeText.text = "Time : " + Timer + "sec";
    }

    // Update is called once per frame
    void Update()
    {

        if ()
        {
            return;// ������update���\�b�h���I��点��
        }

        // ���Ԃ��J�E���g����
        Timer += Time.deltaTime;
        timeText.text = "Time:" + Timer.ToString("f1") + "sec";
    }
}
