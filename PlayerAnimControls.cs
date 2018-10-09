using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if(Mathf.Abs(x) > Mathf.Abs(y))
        {
            GetComponent<Animator>().SetFloat("x", x);
            GetComponent<Animator>().SetFloat("y", 0);
        }else if(Mathf.Abs(x) < Mathf.Abs(y))
        {
            GetComponent<Animator>().SetFloat("x", 0);
            GetComponent<Animator>().SetFloat("y", y);
        }
        if(x == 0 && y == 0)
        {
            GetComponent<Animator>().SetBool("idle", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("idle", false);
        }
        /*if(x != 0)
        {
            GetComponent<Animator>().SetFloat("x", x);
            GetComponent<Animator>().SetBool("idle", false);
        }
        else if(y != 0)
        {
            GetComponent<Animator>().SetFloat("y", y);
            GetComponent<Animator>().SetBool("idle", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("idle", true);
        }*/
		
	}
}
