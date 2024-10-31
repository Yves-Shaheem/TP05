using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] Transform leftSensor, rightSensor;
    [SerializeField] string name;
    Ray rayon;
    RaycastHit hit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        rayon = new Ray(leftSensor.position, transform.TransformDirection(Vector3.forward));
        if(Physics.Raycast(rayon, out hit,Mathf.Infinity)){
            Debug.Log(name+"'sLeft Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);
        }

        Debug.DrawRay(leftSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
        rayon = new Ray(rightSensor.position, transform.TransformDirection(Vector3.forward));
        if (Physics.Raycast(rayon, out hit, Mathf.Infinity)){
            Debug.Log( name+"'s Right Sensor Objet:" + hit.collider.name + " Distance:" + hit.distance);
        }
        Debug.DrawRay(rightSensor.position, transform.TransformDirection(Vector3.forward) * 10f, Color.yellow);
    
        
    }
}
