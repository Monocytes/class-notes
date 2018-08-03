using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {
    public GameObject projectilePrefab;
    public Transform firingPoint;
    public float powerOne = 1000;
    public float powerTwo = 2000;
    public float powerThree = 3000;
    public float firingSpeed = 5000;

    public bool isPlayer;


    void Start()
    {
        if(!isPlayer)
        {
            InvokeRepeating("Fire", 2f, 1f);
        }

    }


	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            firingSpeed = powerOne;

        if (Input.GetKeyDown(KeyCode.Alpha2))
            firingSpeed = powerTwo;

        if (Input.GetKeyDown(KeyCode.Alpha3))
            firingSpeed = powerThree;

        if (!isPlayer)
            transform.Rotate(Vector3.left * 5);



        if (Input.GetButtonDown("Fire1") && isPlayer)
            Fire();
		
	}

    void Fire()
    {
        GameObject projectile = Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
        projectile.GetComponent<Rigidbody>().AddForce(firingPoint.TransformDirection(Vector3.forward) * firingSpeed);
    }
}
