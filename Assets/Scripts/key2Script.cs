using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript2 : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if (other.collider.CompareTag("Player"))
        {
            GameObject.Find("ExitDoor").GetComponent<ExitDoor>().key2Taken=true;
            Debug.Log("key2 taken");
            Destroy(gameObject);

        }
        
    }
}
