using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : AN_Button
{
	Animator anim;
	public LeversManager leverNum;
    // Start is called before the first frame update
    void Start()
    {
	    anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKeyDown(KeyCode.E) && NearView()) 
	    {
		    anim.SetBool("LeverUp", true);
		    leverNum.lever = true;
	    }
	    
    }
    
	bool NearView() // it is true if you near interactive object
	{
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		direction = transform.position - Camera.main.transform.position;
		angleView = Vector3.Angle(Camera.main.transform.forward, direction);
		if (angleView < 45f && distance < 2f) return true;
		else return false;
	}
}
