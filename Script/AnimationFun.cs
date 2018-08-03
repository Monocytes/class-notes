using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFun : MonoBehaviour {
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            anim.SetTrigger("Hit");
        }
    }
    void OnCollisionEnter (Collision collision)
    {
        anim.SetTrigger("Hit");
    }
}
