using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTrigger : MonoBehaviour
{
    public GameObject player;
    public Rigidbody homeBody1;
    public Rigidbody homeBody2;
    public Rigidbody homeBody3;
    public Rigidbody homeBody4;
    public Rigidbody homeBody5;
    public Rigidbody homeBody6;
    public Rigidbody homeBody7;
    public Rigidbody homeBody8;
    public Rigidbody homeBody9;
    public Rigidbody homeBody10;
    bool bCollision;

    // Start is called before the first frame update
    void Start()
    {
        homeBody1.GetComponent<Rigidbody>();
        homeBody2.GetComponent<Rigidbody>();
        homeBody3.GetComponent<Rigidbody>();
        homeBody4.GetComponent<Rigidbody>();
        homeBody5.GetComponent<Rigidbody>();
        homeBody6.GetComponent<Rigidbody>();
        homeBody7.GetComponent<Rigidbody>();
        homeBody8.GetComponent<Rigidbody>();
        homeBody9.GetComponent<Rigidbody>();
        homeBody10.GetComponent<Rigidbody>();

        homeBody1.constraints = RigidbodyConstraints.FreezeAll;
        homeBody2.constraints = RigidbodyConstraints.FreezeAll;
        homeBody3.constraints = RigidbodyConstraints.FreezeAll;
        homeBody4.constraints = RigidbodyConstraints.FreezeAll;
        homeBody5.constraints = RigidbodyConstraints.FreezeAll;
        homeBody6.constraints = RigidbodyConstraints.FreezeAll;
        homeBody7.constraints = RigidbodyConstraints.FreezeAll;
        homeBody8.constraints = RigidbodyConstraints.FreezeAll;
        homeBody9.constraints = RigidbodyConstraints.FreezeAll;
        homeBody10.constraints = RigidbodyConstraints.FreezeAll;
                
        bCollision = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.name == player.name)
        {
            homeBody1.constraints = RigidbodyConstraints.None;
            homeBody2.constraints = RigidbodyConstraints.None;
            homeBody3.constraints = RigidbodyConstraints.None;
            homeBody4.constraints = RigidbodyConstraints.None;
            homeBody5.constraints = RigidbodyConstraints.None;
            homeBody6.constraints = RigidbodyConstraints.None;
            homeBody7.constraints = RigidbodyConstraints.None;
            homeBody8.constraints = RigidbodyConstraints.None;
            homeBody9.constraints = RigidbodyConstraints.None;
            homeBody10.constraints = RigidbodyConstraints.None;

            bCollision = true;
        }
    }

    bool Collision()
    {
        return bCollision;
    }
}
