using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// LoadScene���g�����߂ɕK�v
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;        // ��������
    private Rigidbody rb;           // Rigidbody
    Rigidbody rigid3D;
    public float jumpForce = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody���擾
        rb = GetComponent<Rigidbody>();
        rigid3D = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // �J�[�\���L�[�̓��͂��擾
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // �J�[�\���L�[�̓��͂ɍ��킹�Ĉړ�������ݒ�
        var movement = new Vector3(moveHorizontal, 0, moveVertical);
        var movejump = new Vector3(0, 1, 0);

        // �W�����v����
        if (Input.GetKeyDown(KeyCode.Space) && (int)this.rigid3D.velocity.y <= 0)
        {
            this.rigid3D.AddForce(movejump * this.jumpForce);
        }

        // Rigidbody�ɗ͂�^���ċʂ𓮂���
        rb.AddForce(movement * speed);

        // ��ʊO�ɏo���ꍇ�͍ŏ�����
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("Misaki_Takahashi");// �ēx�Q�[���V�[����ǂݍ���
        }

    }
}
