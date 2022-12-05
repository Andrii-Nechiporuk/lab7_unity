using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent enemy;
    public Transform PlayerTarget;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float minDist = 10;
        float dist = Vector3.Distance(enemy.gameObject.transform.position, PlayerTarget.position);
        if (dist < minDist)
        {
            enemy.SetDestination(PlayerTarget.position);
        }
    }
}
