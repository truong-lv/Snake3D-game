using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlane : MonoBehaviour {
    [SerializeField]
    private Transform centerBackground;
    [SerializeField]
    private Transform upperBackground;
    [SerializeField]
    private Transform lowerBackground;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z >= lowerBackground.position.z + 50)
        {
            lowerBackground.position = new Vector3(lowerBackground.position.x, lowerBackground.position.y, lowerBackground.position.z + 200);
        }
        if(transform.position.z >= upperBackground.position.z+50)
        {
            upperBackground.position = new Vector3(upperBackground.position.x, upperBackground.position.y, upperBackground.position.z +200);
        }
        if (transform.position.z >= centerBackground.position.z+50)
        {
            centerBackground.position = new Vector3(centerBackground.position.x, centerBackground.position.y, centerBackground.position.z +200);
        }
	}
}
