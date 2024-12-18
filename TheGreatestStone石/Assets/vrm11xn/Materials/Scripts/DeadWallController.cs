using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityChan;
using TMPro;

public class DeadWallController : MonoBehaviour
{
    public float speed = 0.05f;
    public float max_x = 10.0f;
    public GameObject player;
    public GameObject text;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(speed, 0, 0);

        var pos = this.gameObject.transform.position;
        if (pos.x > max_x || pos.x < (-max_x))
		{
            speed *= -1;
		}

        if (isGameOver && Input.GetMouseButton(0))
		{
            Restart();
		}
    }

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name == player.name)
		{
            text.GetComponent<TextMeshProUGUI>().text = "GameOver...";
            text.SetActive(true);

            player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;

            player.GetComponent<Animator>().enabled = false;

            isGameOver = false;
		}
	}

    private void Restart()
	{
        Scene loadScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadScene.name);
	}
}
