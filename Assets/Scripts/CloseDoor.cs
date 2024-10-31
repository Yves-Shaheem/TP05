using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{

    public Animator animator;
    public InfoPoint info;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            info.TextChange("Bienvenue dans le labyrinthe, faites attention à l'ennemie");
            
            Debug.Log("Inside the Laby");
            animator.SetBool("isClosed", true);
        }
        }
}
