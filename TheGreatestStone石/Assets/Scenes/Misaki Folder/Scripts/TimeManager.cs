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
    private bool isGoal = false;     // �S�[���������ǂ������肷��

    void OnTriggerEnter(Collider collision)
    {
        // �������Ă����I�u�W�F�N�g�̖��O���v���C���[�̖��O�Ɠ����Ƃ�
        if (collision.name == player.name)
        {
            // �S�[�������true�ɂ���
            isGoal = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // �C���X�^���X����
        timeText.text = "Time : " + Timer + "sec";
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoal==true)
        {
            return;// ������update���\�b�h���I��点��
        }

        // ���Ԃ��J�E���g����
        Timer += Time.deltaTime;
        timeText.text = "Time:" + Timer.ToString("f1") + "sec";
    }
}
