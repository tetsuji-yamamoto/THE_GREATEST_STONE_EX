using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// LoadSceneを使うために必要
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;        // 動く速さ
    private Rigidbody rb;           // Rigidbody
    Rigidbody rigid3D;
    public float jumpForce = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbodyを取得
        rb = GetComponent<Rigidbody>();
        rigid3D = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        // カーソルキーの入力に合わせて移動方向を設定
        var movement = new Vector3(moveHorizontal, 0, moveVertical);
        var movejump = new Vector3(0, 1, 0);

        // ジャンプする
        if (Input.GetKeyDown(KeyCode.Space) && (int)this.rigid3D.velocity.y <= 0)
        {
            this.rigid3D.AddForce(movejump * this.jumpForce);
        }

        // Rigidbodyに力を与えて玉を動かす
        rb.AddForce(movement * speed);

        // 画面外に出た場合は最初から
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene("Misaki_Takahashi");// 再度ゲームシーンを読み込み
        }

    }
}
