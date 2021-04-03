using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameState
{
    PrePlay, Playing, Pause, GameOver
}
public class GameManager : MonoBehaviour {
    static public GameManager Instance;
    public GameState mGameState;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

}
