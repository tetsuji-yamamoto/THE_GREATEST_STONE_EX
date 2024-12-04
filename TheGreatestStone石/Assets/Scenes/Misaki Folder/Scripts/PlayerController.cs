using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// LoadSceneを使うために必要
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;        // 動く速さ
    private Rigidbody rb;           // Rigidbody
    public GameObject scoreText;    // スコア表示
    public GameObject winText;      // win表示UI
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
