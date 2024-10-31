using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyItem : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("Energy drink taken");
            GameObject.Find("ClairePlayer").GetComponent<BarManager>().GetEnergy(5f);
            Destroy(gameObject);

        }
        
    }
}
