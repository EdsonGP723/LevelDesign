using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeversManager : MonoBehaviour
{
	public bool lever;
	public GameObject[] walls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
	    if (lever){
		    foreach (GameObject wall in walls){
		    	wall.SetActive(false);
		    }
	    }
	}
}
