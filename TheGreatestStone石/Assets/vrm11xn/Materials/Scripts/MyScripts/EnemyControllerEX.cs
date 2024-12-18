using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyControllerEX : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    void Update()
    {
        agent.destination = target.position;
    }
}
