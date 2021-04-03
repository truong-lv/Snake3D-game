using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speedMove = 22;
    public float speedTurn=10;
    public float timeLast;
    public float timeCreate = 4;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.mGameState == GameState.Playing /*&& GameManager.Instance.mGameState != GameState.GameOver*/)
        {

            transform.Translate(Vector3.forward * Time.deltaTime * (speedMove));
            Vector3 posScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
            
            if (Input.GetMouseButton(0))
            {
                float distance = transform.position.z - Camera.main.transform.position.z;
                Vector3 tam = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
                Vector3 posmouse = Camera.main.ScreenToWorldPoint(tam);
                Debug.Log("posScreen"+posScreen);
                Debug.Log("posmouse"+posmouse);
                if (posmouse.x < posScreen.x/2)//Input.GetKey(KeyCode.D))////))
                {
                    Vector3 temp = transform.position;
                    temp.x -= Time.deltaTime * (speedTurn);
                    temp.y = transform.position.y;
                    transform.position = temp;
                    //transform.position = Vector3.right * Time.deltaTime * speedMove;
                    Debug.Log("phai");
                }
                if (posmouse.x > posScreen.x/2)//Input.GetKey(KeyCode.A))////)
                {
                    Vector3 temp = transform.position;
                    temp.x += Time.deltaTime *( speedTurn);
                    temp.y = transform.position.y;
                    transform.position = temp;
                    Debug.Log("trai");
                }
            }
        }
    }
}