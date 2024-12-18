using UnityEngine;

public class Obstacle : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        // „P„‚„€„r„u„‚„‘„u„}, „‰„„„€ „ƒ„„„€„|„{„~„€„r„u„~„y„u „„‚„€„y„x„€„Š„|„€ „ƒ „q„…„|„„w„~„y„{„€„}
        if (collision.gameObject.CompareTag("Stone")) {
            // „C„u„~„u„‚„p„ˆ„y„‘ „ƒ„|„…„‰„p„z„~„€„s„€ „{„€„|„y„‰„u„ƒ„„„r„p „€„‰„{„€„r
            int points = Random.Range(10, 41);

            // „D„€„q„p„r„|„‘„u„} „€„‰„{„y „y„s„‚„€„{„…
            PlayerScore.Instance.AddPoints(points);

            // „Q„p„x„‚„…„Š„p„u„} „€„q„Œ„u„{„„
            Destroy(gameObject);
        }
    }
}