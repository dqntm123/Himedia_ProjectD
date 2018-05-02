﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {


    public float enemySP;
    public GameObject lvManager;
    public GameObject hpMG;
    public float damage;
    public float exp;
	public enum ENEMYSTATE
    {
        NONE,
        ATTACK,
        DEAD
    }
    public ENEMYSTATE enemystate;

    void Start()
    {
        lvManager = GameObject.Find("LevelManager");
        hpMG = GameObject.Find("HPManager");
    }
    void Update()
    {
        switch (enemystate)
        {
            case ENEMYSTATE.NONE:
                transform.Translate(-enemySP * Time.deltaTime, 0, 0);
                break;
            case ENEMYSTATE.ATTACK:

                break;
            case ENEMYSTATE.DEAD:
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            lvManager.GetComponent<LevelManager>().expVaule += exp;
            lvManager.GetComponent<LevelManager>().levelBar.transform.localScale += new Vector3(0, exp / lvManager.GetComponent<LevelManager>().expLimit * 360, 0);
            hpMG.GetComponent<HPManager>().player.transform.localScale -= new Vector3(damage/ hpMG.GetComponent<HPManager>().playerHP*360, 0,0);
            enemystate = ENEMYSTATE.DEAD;
        }
    }
}
