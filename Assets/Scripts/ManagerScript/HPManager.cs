using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour {

    public float playerHP;
    public float castleHP;
    public float[] unitHP;
    public float[] enemyHP;
    public GameObject playerGauge;
    public GameObject castleGauge;
    public GameObject[] unitGauge;
    public GameObject[] enemyGauge;
    void Start()
    {
        playerGauge = GameObject.Find("PlayHP");
        castleGauge = GameObject.Find("CastleHP");
    }
    void Update()
    {

    }
}
