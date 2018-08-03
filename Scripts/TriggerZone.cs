using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour {

    public GameObject door;

	void OnTriggerEnter (Collider collider)
    {
        Debug.Log(collider.gameObject.name);
        door.SetActive(false);
    }

    void OnTriggerStay (Collider collider)
    {
        if (collider.gameObject.tag == "Player")
            collider.gameObject.GetComponent<Player>().health -= 1;
    }

    void OnTriggerExit (Collider collider)
    {
        door.SetActive(true);
    }
}
