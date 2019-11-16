using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NPC : MonoBehaviour
{
    public GameObject npc;
     void Start()
    {
        npc.GetComponent<NavMeshAgent>().enabled = true;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           // gothit = 1;
            npc.GetComponent<Animator>().Play("Shoved");
            
           npc.GetComponent<NavMeshAgent>().enabled = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           npc.GetComponent<Animator>().Play("Walking");

          npc.GetComponent<NavMeshAgent>().enabled = true;
        }

    }
}
