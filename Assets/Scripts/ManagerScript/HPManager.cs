using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour {

    public float playerHP;
    public float castleHP;
    public GameObject playerGauge;
    public GameObject castleGauge;
    void Start()
    {
        playerGauge = GameObject.Find("PlayHP");
        castleGauge = GameObject.Find("CastleHP");
    }
    void Update()
    {

    }
}
