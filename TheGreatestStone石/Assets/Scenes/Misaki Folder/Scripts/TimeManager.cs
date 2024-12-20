using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeMa : MonoBehaviour
{
    public TextMeshProUGUI timeText; // 時間表示用テキスト
    public float Timer = 0.0f;       // 時間を保存
    public GameObject player;        // プレイヤーを格納する変数
    public GameObject text;          // テキストを格納する変数
    private bool isGoal = false;     // ゴールしたかどうか判定する

    void OnTriggerEnter(Collider collision)
    {
        // 当たってきたオブジェクトの名前がプレイヤーの名前と同じとき
        if (collision.name == player.name)
        {
            // ゴール判定をtrueにする
            isGoal = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // インスタンス生成
        timeText.text = "Time : " + Timer + "sec";
    }

    // Update is called once per frame
    void Update()
    {
        if (isGoal==true)
        {
            return;// ここでupdateメソッドを終わらせる
        }

        // 時間をカウントする
        Timer += Time.deltaTime;
        timeText.text = "Time:" + Timer.ToString("f1") + "sec";
    }
}
