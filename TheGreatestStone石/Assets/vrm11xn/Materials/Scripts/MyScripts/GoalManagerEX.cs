using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GoalManager1 : MonoBehaviour
{
    public GameObject player;
    public GameObject text;
    private bool isGoal = false;

    void OnTriggerEnter(Collider collision) {
        if (collision.name == player.name) {
            text.GetComponent<TextMeshProUGUI>().text = "Stage Clear!";
            text.SetActive(true);
            isGoal = true;
        }
    }

    private void Update() {
        if (isGoal && Input.GetMouseButton(0)) {
            Restart();
        }
    }

    private void Restart() {
        Scene loadScene = SceneManager.GetActiveScene(); // „„€„|„…„‰„p„u„} „ƒ„ƒ„„|„{„… „~„p „„„u„{„…„‹„…„ „p„{„„„y„r„~„…„ „ƒ„ˆ„u„~„… „y „ƒ„€„‡„‚„p„~„‘„u„} „u„v „r „„u„‚„u„}„u„~„~„€„z loadScene
        SceneManager.LoadScene(loadScene.name); // „„u„‚„u„x„p„s„‚„…„w„p„u„} „„„u„{„…„‹„…„ „ƒ„ˆ„u„~„… „„€ „u„v „y„}„u„~„y.
    }
}
