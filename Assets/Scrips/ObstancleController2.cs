using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstancleController2 : MonoBehaviour {
    public float turn=0;
    public float speed=3;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	if(transform.position.x>=4.5)
        {
            turn = 0;
        }
    else if(transform.position.x<=-4.5)
        {
            turn = 1;
        }
    
        if(turn==1)
        { 
            transform.Translate(Vector3.right * Time.deltaTime*speed);
        }
        if(turn==0)
        {
            transform.Translate(Vector3.left * Time.deltaTime*speed);
        }
    }
  
}
