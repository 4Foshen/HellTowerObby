using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckPoint : MonoBehaviour
{
    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !activated)
        {
            CheckPointManager.Instance.SetPlayerSpawnPosition(transform.position);
            Debug.Log("New point");

            activated = true;
        }
    }
}

