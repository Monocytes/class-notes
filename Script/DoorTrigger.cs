using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

    public Animator anim;


	
	void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.tag=="Player")
            anim.SetTrigger("Door_Open");

    }
    void OnTriggerExit (Collider collider)
    {
        if (collider.gameObject.tag =="Player")
            anim.SetTrigger("Door_Close");
    }
}
