using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;       // プレイヤーを格納するための変数
    public GameObject text;         // テキストを格納するための変数
    private bool isGoal = false;    // ゴールしたかどうか判定する

    void OnTriggerEnter(Collider collision)
    {
        // 当たってきたオブジェクトの名前がプレイヤーの名前と同じとき
        if (collision.name == player.name)
        {
            Debug.Log("ゴールした！！！");
            // テキストの内容を変更する
            text.GetComponent<TextMeshProUGUI>().text = "GOAL!!!";
            // テキストをオンにして非表示->表示にする
            text.SetActive(true);
            // ゴール判定をtrueにする
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
            SceneManager.LoadScene("Misaki_Takahashi"); // 再度ゲームシーンを読み込み
        }
    }
}
