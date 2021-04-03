using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public int score;
    public int scoreBest;
    public static ScoreManager Instance;//báo cho project bik là biến đc sử dụng
    public void AddScore(int n)
    {
        score += n;
        if (scoreBest < score)
        {
            scoreBest = score;
            UIManager.Instance.txtScoreBest.GetComponent<Text>().text = scoreBest.ToString();
            //lưu điểm cao nhất
            PlayerPrefs.SetInt("SCOREBEST", scoreBest);
        }
        //Bebug.Log(score);
        UIManager.Instance.txtScore.GetComponent<Text>().text = score.ToString();
    }
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        scoreBest = PlayerPrefs.GetInt("SCOREBEST");
        UIManager.Instance.txtScoreBest.GetComponent<Text>().text = scoreBest.ToString();
    }
    public int GetScore()
    {
        return score;
    }
    public int GetScoreBest()
    {
        return scoreBest;

    }
    // Update is called once per frame
    void Update () {
		
	}
}
