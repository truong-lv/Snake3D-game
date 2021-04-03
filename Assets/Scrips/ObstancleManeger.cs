using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstancleManeger : MonoBehaviour
{
    public float ySize = 4;
    public float ramdomObs;
    public float ramdomObs2;
    public float ramdomObs4;
    public float ramdomObs42;

    public float timeLast2;
    public float timeCreate2 = 1;
    public float XSize2 = 3.8f;
    public GameObject obsPrefab;
    public GameObject obsPrefab2;
    public GameObject obsPrefab21;
    public GameObject obsPrefab22;
    public GameObject obsPrefab3;
    public GameObject obsPrefab4;
    public GameObject obsPrefab41;
    public GameObject obsPrefab412;
    public GameObject obsPrefab413;
    public Vector3 curPos;
    public Vector3 curPos2;
    public Vector3 curPos3;
    public Vector3 curPos4;
    public GameObject curObs;
    public GameObject curObs2;
    public GameObject curObs3;
    public GameObject curObs4;
    [SerializeField]
    private Transform targetToFollow2;
    // Use this for initialization
    void AddNewObs()//obstancle 1
    {
        RamdomPos();
        curObs = GameObject.Instantiate(obsPrefab, curPos, Quaternion.identity) as GameObject;
    }
    void RamdomPos()
    {
        curPos = new Vector3(Random.Range(XSize2 * -1, XSize2 * 1), 0.43f, targetToFollow2.position.z + 60);
    }


    void AddNewObs2()//obstancle2
    {
        RamDomPos2();
        curObs2 = GameObject.Instantiate(obsPrefab2, curPos2, Quaternion.identity) as GameObject;
    }
    void AddNewObs21()//obstancle2.1
    {
        RamDomPos2();
        curObs2 = GameObject.Instantiate(obsPrefab21, curPos2, Quaternion.identity) as GameObject;
    }
    void AddNewObs22()//obstancle2.2
    {
        RamDomPos2();
        curObs2 = GameObject.Instantiate(obsPrefab22, curPos2, Quaternion.identity) as GameObject;
    }
    void RamDomPos2()
    {
        curPos2 = new Vector3(transform.position.x, 0.5f, targetToFollow2.position.z + 60);
    }


    void AddNewObs3()//obstancle3
    {
        RamDomPos3();
        curObs3 = GameObject.Instantiate(obsPrefab3, curPos3, Quaternion.identity) as GameObject;
    }
    void RamDomPos3()
    {
        curPos3 = new Vector3(transform.position.x, 0.43f, targetToFollow2.position.z + 60);
    }


    void AddNewObs4()//obstancle4
    {
        RamDomPos4();
        curObs4 = GameObject.Instantiate(obsPrefab4, curPos4, Quaternion.identity) as GameObject;
    }
    void AddNewObs41()//obstancle4
    {
        RamDomPos4();
        curObs4 = GameObject.Instantiate(obsPrefab41, curPos4, Quaternion.identity) as GameObject;
    }
    void AddNewObs412()//obstancle4
    {
        RamDomPos4();
        curObs4 = GameObject.Instantiate(obsPrefab412, curPos4, Quaternion.identity) as GameObject;
    }
    void AddNewObs413()//obstancle4
    {
        RamDomPos4();
        curObs4 = GameObject.Instantiate(obsPrefab413, curPos4, Quaternion.identity) as GameObject;
    }
    void RamDomPos4()
    {
        curPos4 = new Vector3(transform.position.x, 0.5f, targetToFollow2.position.z + 60);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.mGameState == GameState.Playing)
        {
            if (ScoreManager.Instance.score <= 5)
            {
                timeCreate2 = 1;
                if (Time.time - timeLast2 > timeCreate2)
                {
                    AddNewObs();
                    timeLast2 = Time.time;
                }
            }
            if (ScoreManager.Instance.score > 5 && ScoreManager.Instance.score <= 10)
            {
                timeCreate2 = 1;
                if (Time.time - timeLast2 > timeCreate2)
                {
                    ramdomObs = Random.Range(1, 3);
                    if (ramdomObs == 1)
                    {
                        AddNewObs();
                    }
                    if (ramdomObs == 2)
                    {
                        RandomObs2();

                    }
                    timeLast2 = Time.time;
                }
            }
            if (ScoreManager.Instance.score > 10 && ScoreManager.Instance.score <= 15)
            {
                timeCreate2 = 0.8f;
                if (Time.time - timeLast2 > timeCreate2)
                {
                    ramdomObs = Random.Range(1, 4);
                    if (ramdomObs == 2)
                    {
                        RandomObs2();
                    }
                    if (ramdomObs == 3)
                    {
                        AddNewObs3();
                    }
                    timeLast2 = Time.time;
                }
            }
            if (ScoreManager.Instance.score > 15 && ScoreManager.Instance.score <= 25)
            {
                timeCreate2 = 0.7f;
                if (Time.time - timeLast2 > timeCreate2)
                {
                    ramdomObs = Random.Range(1, 5);
                    if (ramdomObs == 2)
                    {
                        RandomObs2();
                    }
                    if (ramdomObs == 3)
                    {
                        AddNewObs3();
                    }
                    if (ramdomObs == 4)
                    {
                        AddNewObs4();
                    }
                    timeLast2 = Time.time;
                }
            }
            if (ScoreManager.Instance.score > 25)
            {
                if (ScoreManager.Instance.score <= 45)
                { timeCreate2 = 0.7f; }
                if (ScoreManager.Instance.score > 45)
                { timeCreate2 = 0.6f; }
                if (Time.time - timeLast2 > timeCreate2)
                {
                    ramdomObs = Random.Range(0, 6);

                    if (ramdomObs == 1)
                    {
                        AddNewObs();
                    }
                    if (ramdomObs == 2)
                    {
                        RandomObs2();
                    }
                    if (ramdomObs == 3)
                    {
                        AddNewObs3();
                    }
                    if (ramdomObs == 4)
                    {
                        RandomObs4();
                    }
                    if(ScoreManager.Instance.score > 40 && ramdomObs == 5)
                    {
                        RandomObs42();
                    }
                    timeLast2 = Time.time;
                }
            }



        }

    }
    public void RandomObs2()
    {
        ramdomObs2 = Random.Range(1, 3);
        if (ramdomObs2 == 1)
        { AddNewObs2(); }
        if (ramdomObs2 == 2)
        { AddNewObs21(); }
        if (ramdomObs2 == 3)
        { AddNewObs22(); }
    }
    public void RandomObs4()
    {
        ramdomObs4 = Random.Range(1, 3);
        if (ramdomObs4 == 1)
        { AddNewObs4(); }
        if(ramdomObs4==2)
        { AddNewObs41(); }
    }
    public void RandomObs42()
    {
        ramdomObs42 = Random.Range(1, 3);
        if (ramdomObs42 == 1)
        { AddNewObs412(); }
        if(ramdomObs42==2)
        { AddNewObs413(); }
    }
}
