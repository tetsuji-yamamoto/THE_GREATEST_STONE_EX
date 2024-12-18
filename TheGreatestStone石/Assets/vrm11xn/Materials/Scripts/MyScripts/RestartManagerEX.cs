using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityChan;
using TMPro;

public class RestartManagerEX : MonoBehaviour
{
    private GameObject player;
    private GameObject text;
    private bool isGameOver = false;
    
    public RestartManagerEX(GameObject player, GameObject text) {
        this.player = player;
        this.text = text;
    }

    public void PrintGameOver() {
        text.GetComponent<TextMeshProUGUI>().text = "Game Over";
        text.SetActive(true);

        player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        player.GetComponent<Animator>().enabled = false;
        isGameOver = true;
    }

    public void Restart() {
        Scene loadScene = SceneManager.GetActiveScene(); // „„€„|„…„‰„p„u„} „ƒ„ƒ„„|„{„… „~„p „„„u„{„…„‹„…„ „p„{„„„y„r„~„…„ „ƒ„ˆ„u„~„… „y „ƒ„€„‡„‚„p„~„‘„u„} „u„v „r „„u„‚„u„}„u„~„~„€„z loadScene
        SceneManager.LoadScene(loadScene.name); // „„u„‚„u„x„p„s„‚„…„w„p„u„} „„„u„{„…„‹„…„ „ƒ„ˆ„u„~„… „„€ „u„v „y„}„u„~„y.
    }

    public bool IsGameOver() {
        return isGameOver;
    }
}
