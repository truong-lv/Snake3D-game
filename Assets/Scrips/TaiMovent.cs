using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaiMovent : MonoBehaviour {
    public float Speed;
    public Vector3 tailTarget;
    public GameObject tailTargetObj;
    public SakeMainController mainSnake;
	// Use this for initialization
    void Start () {
       mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SakeMainController>();      
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];

    }

    // Update is called once per frame
    void Update()
    {
        if ( GameManager.Instance.mGameState != GameState.Pause)
        {             
                tailTarget = tailTargetObj.transform.position;
                transform.LookAt(tailTarget);            
            transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime*15);
        }
    }
}


