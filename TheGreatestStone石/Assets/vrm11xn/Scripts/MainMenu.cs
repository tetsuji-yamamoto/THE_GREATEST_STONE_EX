using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // „q„y„q„|„y„€„„„u„{„p „t„|„‘ „…„„‚„p„r„|„u„~„y„‘ „ƒ„ˆ„u„~„p„}„y („„u„‚„u„‡„€„t„ „}„u„w„t„… „…„‚„€„r„~„‘„}„y, „x„p„s„‚„…„x„{„p „~„€„r„„‡ „|„€„{„p„ˆ„y„z „y „„„)

public class MainMenu : MonoBehaviour {

    public string GameScene; // „„‚„€„ƒ„„„€ „ƒ„„„‚„€„{„p „ƒ „y„}„u„~„u„} („~„p„x„r„p„~„y„u„}). „H„t„u„ƒ„ „}„ „€„„‚„u„t„u„|„‘„u„} „„„„… „ƒ„„„‚„€„{„…, „‰„„„€„q„ „€„„„€„q„‚„p„x„y„„„ „u„v „r „y„~„ƒ„„u„{„„„€„‚„u, „p „„„p„} „}„ „x„p„s„‚„…„x„y„} „x„p„}„u„ƒ„„„€ „~„u„v „~„p„Š„… „y„s„‚„€„r„…„ „ƒ„ˆ„u„~„…
    public GameObject mainMenuUI; // „{„~„€„„{„y „r „s„|„p„r„~„€„} „}„u„~„

    public void StartGame() {
        SceneManager.LoadScene(GameScene); // „x„t„u„ƒ„ „}„ „„‚„€„ƒ„y„} „}„u„~„u„t„w„u„‚„p „ƒ„ˆ„u„~ „x„p„s„‚„…„x„y„„„ „~„p„Š„… „ƒ„ˆ„u„~„… („…„‚„€„r„u„~„ 1)

    }

    public void ExitGame() {
        Debug.Log("Pressed");
        Application.Quit(); // „†„…„~„{„ˆ„y„‘ „x„p„{„‚„„„„y„‘ „y„s„‚„
    }

}
