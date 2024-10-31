using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript0 : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("key0 taken");
            GameObject.Find("ExitDoor").GetComponent<ExitDoor>().key0Taken=true;
            Destroy(gameObject);

        }
        
    }
}
