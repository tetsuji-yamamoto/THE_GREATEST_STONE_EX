using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;       // �v���C���[���i�[���邽�߂̕ϐ�
    public GameObject text;         // �e�L�X�g���i�[���邽�߂̕ϐ�
    private bool isGoal = false;    // �S�[���������ǂ������肷��

    void OnTriggerEnter(Collider collision)
    {
        // �������Ă����I�u�W�F�N�g�̖��O���v���C���[�̖��O�Ɠ����Ƃ�
        if (collision.name == player.name)
        {
            Debug.Log("�S�[�������I�I�I");
            // �e�L�X�g�̓��e��ύX����
            text.GetComponent<TextMeshProUGUI>().text = "GOAL!!!";
            // �e�L�X�g���I���ɂ��Ĕ�\��->�\���ɂ���
            text.SetActive(true);
            // �S�[�������true�ɂ���
            isGoal = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoal && Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Misaki_Takahashi"); // �ēx�Q�[���V�[����ǂݍ���
        }
    }
}
