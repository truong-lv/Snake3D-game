using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    static public UIManager Instance;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    public GameObject StartCanvat;
    public GameObject txtScore;
    public GameObject txtScoreBest;
    //In panel GameOver
    public GameObject pnlGameOver;
    public GameObject txtPnlScore;
    public GameObject txtPnlScoreBest;

    public void EventPlayAgain()
    {
        Application.LoadLevel(0);

    }
    public void EventPlay()
    {
        GameManager.Instance.mGameState = GameState.Playing;
        StartCanvat.SetActive(false);//làm startcanvat biến mất nếu nhấn play
        
    }
}

