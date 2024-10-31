using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public bool key0Taken = false;
    public bool key1Taken = false;
    public bool key2Taken = false;

    public Animator animator;
    public InfoPoint info;
    
    private void Update()
    {
        if (key0Taken && key1Taken && key2Taken){
            animator.SetBool("isOpen", true);
            
        }
    }
        
}
