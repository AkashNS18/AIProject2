using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            this.gameObject.transform.position = new Vector3(12, 1,34);
        }
    }
}
