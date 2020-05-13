using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Transform target3;

    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectWithTag("Enemy").transform.position == target3.position)
        {
            agent.SetDestination(target1.position);
        }

        if (GameObject.FindGameObjectWithTag("Enemy").transform.position == target1.position)
        {
            agent.SetDestination(target2.position);
        }

        if (GameObject.FindGameObjectWithTag("Enemy").transform.position == target2.position)
        {
            agent.SetDestination(target3.position);
        }
    }
}
