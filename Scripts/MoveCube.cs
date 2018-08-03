using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour 
{

	public int startingHealth = 100; //defalut for int/float is 0 if not defining value
	public int currentHealth;
	public int damage = 10;
	public float accuracy = 100.0f; //with float, need to put a f at the end of no.
	public string name = "May"; 
	public Vector3 targetPosition; 



	// Use this for initialization
	void Start () 
	{
		
		currentHealth = startingHealth - damage;
		//Debug.Log (currentHealth);
		gameObject.transform.position = new Vector3 (0,0,0);


	}
	
	// Update is called once per frame - normally 30-60 can up to 144 fps
	void Update () 
	{
		
		
	}
}
