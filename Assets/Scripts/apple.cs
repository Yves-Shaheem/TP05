using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
     private void OnCollisionEnter(Collision other) {
        
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("apple taken");
            GameObject.Find("ClairePlayer").GetComponent<BarManager>().GetFood(10f);
            Destroy(gameObject);

        }
        
    }
}
