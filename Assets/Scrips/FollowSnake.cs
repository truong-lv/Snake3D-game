using UnityEngine;

public class FollowSnake : MonoBehaviour {
    [SerializeField]
    private Transform targetToFollow;
    // Update is called once per frame
    void Start()
    {
    
    }
    void Update () {
        
	}
    private void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, targetToFollow.position.z-15);
        
    }
}
