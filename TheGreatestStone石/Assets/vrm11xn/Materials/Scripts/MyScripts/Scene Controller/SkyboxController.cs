using UnityEngine;

public class SkyboxRotator : MonoBehaviour {
    public float rotationSpeed = 10f; // „R„{„€„‚„€„ƒ„„„ „r„‚„p„‹„u„~„y„‘ „ƒ„{„p„z„q„€„{„ƒ„p

    private void Start() {
        RenderSettings.skybox.SetFloat("_Rotation", 150.0f);
    }

    void Update() {
        // „B„„‰„y„ƒ„|„‘„u„} „~„€„r„„z „…„s„€„| „r„‚„p„‹„u„~„y„‘
        float rotation = Time.time * rotationSpeed;

        // „T„ƒ„„„p„~„p„r„|„y„r„p„u„} „…„s„€„| „r„‚„p„‹„u„~„y„‘ „r „}„p„„„u„‚„y„p„| „ƒ„{„p„z„q„€„{„ƒ„p
        RenderSettings.skybox.SetFloat("_Rotation", 150.0f + rotation);
    }
}