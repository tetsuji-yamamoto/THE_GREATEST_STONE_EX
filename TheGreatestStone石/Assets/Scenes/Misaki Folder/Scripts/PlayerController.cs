using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// LoadScene���g�����߂ɕK�v
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;        // ��������
    private Rigidbody rb;           // Rigidbody
    public GameObject scoreText;    // �X�R�A�\��
    public GameObject winText;      // win�\��UI
    Rigidbody rigid3D;
    public float jumpForce = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
