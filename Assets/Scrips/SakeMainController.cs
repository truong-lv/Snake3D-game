using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SakeMainController : MonoBehaviour {
    public float timeLast;
    public float timeCreate = 4;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float z_offset = 0.5f;
    public GameObject TailPrefab;
    private AudioSource audioSource;
    public AudioClip musicEat;
    public AudioClip musicOver;
    // Use this for initialization
    void Start () {
        tailObjects.Add(gameObject);
        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {       
        
        if(transform.position.y >= 0.5 || transform.position.y <= 0.48)
        {
            GameManager.Instance.mGameState = GameState.GameOver;
            UIManager.Instance.pnlGameOver.SetActive(true);
            UIManager.Instance.txtPnlScore.GetComponent<Text>().text = ScoreManager.Instance.GetScore().ToString();
            UIManager.Instance.txtPnlScoreBest.GetComponent<Text>().text = ScoreManager.Instance.GetScoreBest().ToString();
            
        }
	}
    public void AddTail()
    {
        Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="Food")
        {
            MusicEat();
            AddTail();
            Destroy(other.gameObject);
            ScoreManager.Instance.AddScore(1);
           
        }
        if(other.transform.tag=="Obstancle" )
        {
           
            GameManager.Instance.mGameState = GameState.GameOver;
            GameManager.Instance.mGameState = GameState.Pause;
            UIManager.Instance.pnlGameOver.SetActive(true);
            UIManager.Instance.txtPnlScore.GetComponent<Text>().text = ScoreManager.Instance.GetScore().ToString();
            UIManager.Instance.txtPnlScoreBest.GetComponent<Text>().text = ScoreManager.Instance.GetScoreBest().ToString();
            MusicOVer();
        }
    }
    void MusicOVer()
    {
        audioSource.clip = musicOver;
        audioSource.Play();
    }
    void MusicEat()
    {
        audioSource.clip = musicEat;
        audioSource.Play();
    }
}
