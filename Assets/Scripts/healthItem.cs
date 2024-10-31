using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthItem : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("medkit taken");
            GameObject.Find("ClairePlayer").GetComponent<BarManager>().Heal(50f);
            Destroy(gameObject);

        }
        
    }
}
