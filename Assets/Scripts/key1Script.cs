using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript1 : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if (other.collider.CompareTag("Player"))
        {
            GameObject.Find("ExitDoor").GetComponent<ExitDoor>().key1Taken=true;
            Destroy(gameObject);
            Debug.Log("key1 taken");
        }
        
    }
}
