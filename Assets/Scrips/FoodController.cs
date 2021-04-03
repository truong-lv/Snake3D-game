using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour {
    public float timeLast;    
    public float timeCreate = 0.8f;
    public float XSize = 5;
    public GameObject foodPrefab;
    public Vector3 curPos;
    public GameObject curFood;
    [SerializeField]
    private Transform targetToFollow;

    // Use this for initialization
    void AddNewFood () {
        RamdomPos();
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    }
    void RamdomPos()
    {
        curPos = new Vector3(Random.Range(XSize * -1, XSize * 1), 0.43f, targetToFollow.position.z+55);       
    }
    // Update is called once per frame
    void Update () {
        if (GameManager.Instance.mGameState == GameState.Playing)
        {
            
            if (Time.time - timeLast > timeCreate)
            {
                AddNewFood();
                timeLast = Time.time;
            }
        }


	}
}
