using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyEnemy : MonoBehaviour
{
    private NavMeshAgent Werewolf;
    public GameObject Player;
    public float WerewolfDistanceRun = 20.0f;

    
   
    void Start()
    {

        Werewolf = GetComponent<NavMeshAgent>();
        
    }

    
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < WerewolfDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;
            Werewolf.SetDestination(newPos);

        }

    }
}
