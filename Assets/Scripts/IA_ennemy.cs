using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
 
public class IA_ennemy : MonoBehaviour
{
    public Animator animator;
    public bool playerin = false;
    [SerializeField] Transform leftSensor, rightSensor;
    [SerializeField] Transform target;
    NavMeshAgent agent;
    Ray rayon;
    RaycastHit hit;
    
 
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }
 
    // Update is called once per frame
    void Update(){
        rayon = new Ray(leftSensor.position, transform.TransformDirection(Vector3.forward));
        if(Physics.Raycast(rayon, out hit,Mathf.Infinity)){
            Debug.Log("Left Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);
        }

        Debug.DrawRay(leftSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
        rayon = new Ray(rightSensor.position, transform.TransformDirection(Vector3.forward));
        if (Physics.Raycast(rayon, out hit, Mathf.Infinity)){
            Debug.Log("Right Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);
        }
        Debug.DrawRay(rightSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
    
        if(playerin) {
            agent.SetDestination(target.position);
            animator.SetBool("chase", true);
        }else{
            
            animator.SetBool("chase", false);
        }
        
    }
}
