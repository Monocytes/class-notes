using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour {

    float rayDistance = 20;

    void Update ()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.red, rayDistance);
        
        if (Input.GetMouseButton (0))
        {
            
             if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayDistance))
             {
                if (hit.collider.tag == "Bad")
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;


                /*Debug.Log(hit.collider.name);

                if (hit.collider.tag == "Good")
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;

                if (hit.collider.tag == "Bad")
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;

                if (Input.GetMouseButton(0) && hit.collider.tag == "Bad")
                    hit.collider.gameObject.SetActive(false);
                    */
            }
        }
    }
}
