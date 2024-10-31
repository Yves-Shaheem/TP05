using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public InfoPoint info;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            info.TextChange("Bravo, vous vous etes echappé !!");
            Debug.Log("Inside the Laby");
            
        }
        }
}
