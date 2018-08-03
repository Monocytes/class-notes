using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectle : MonoBehaviour {

    void Start()
    {
        Destroy(gameObject, 0.5f);
    }

	void OnCollisionEnter (Collision collision)
	{
        // Debug.Log("Hits " + collision.gameObject.name);
        if (collision.gameObject.tag =="Bad")
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
	}

    void OnCollisionStay (Collision collision)
    {
        //Debug.Log("Hitting " + collision.gameObject.name);
        if(collision.gameObject.tag == "Barrier")
        collision.gameObject.GetComponent<Barrier>().health -= 10;
    }

    void OnCollisionExit (Collision collision)
    {
        Debug.Log("hitting" + collision.gameObject.name);
    }
        
}
