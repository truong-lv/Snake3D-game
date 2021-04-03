using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstancle3 : MonoBehaviour {
    public float speed = 3;
    public float turn = 0;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
       
        if (transform.position.y >= 4)
        {
            turn = 0;
        }
        else if (transform.position.y <= 0.43f)
        {
            turn = 1;
        }

        if (turn == 1)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (turn == 0)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
