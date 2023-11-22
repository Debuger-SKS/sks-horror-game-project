using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    NavMeshAgent nav;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (nav.destination != target.transform.position)
        {
            nav.SetDestination(target.transform.position);
        }
        else
        {
            nav.SetDestination(transform.position);
        }
    }
}
