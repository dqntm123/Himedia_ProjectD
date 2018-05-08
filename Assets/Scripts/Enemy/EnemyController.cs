using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {


    public float enemySP;
    public GameObject lvManager;
    public GameObject hpMG;
    public GameObject effect;
    public GameObject unit;
    public float damage;
    public float exp;
    public float attackTime;
    public float attackResPawnTime;
    public bool unitIn = true;
    public enum ENEMYSTATE
    {
        NONE,
        ATTACK,
        DEAD
    }
    public ENEMYSTATE enemystate;

    void Start()
    {
        gameObject.name = "Enemy1";
        lvManager = GameObject.Find("LevelManager");
        hpMG = GameObject.Find("HPManager");
    }
    void Update()
    {
        switch (enemystate)
        {
            case ENEMYSTATE.NONE:
                gameObject.GetComponentInChildren<Animator>().SetBool("Attack", false);
                transform.Translate(-enemySP * Time.deltaTime, 0, 0);
                break;
            case ENEMYSTATE.ATTACK:
                gameObject.GetComponentInChildren<Animator>().SetBool("Attack", true);
                attackTime += Time.deltaTime;
                if (attackTime >= attackResPawnTime)
                {
                    Instantiate(effect, transform.position, transform.rotation);
                    attackTime = 0;
                }
                break;
            case ENEMYSTATE.DEAD:
                gameObject.GetComponentInChildren<Animator>().SetBool("Die", true);
                Destroy(gameObject,0.65f);
                break;
            default:
                break;
        }
        if(transform.position.x<=-2.2f)
        {
            enemystate = ENEMYSTATE.DEAD;
        }
        if(unitIn==null)
        {
            unitIn = true;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Player")
        {
            hpMG.GetComponent<HPManager>().playerGauge.transform.localScale -= new Vector3(damage / hpMG.GetComponent<HPManager>().playerHP * 360, 0, 0);
            lvManager.GetComponent<LevelManager>().expVaule += exp;
            lvManager.GetComponent<LevelManager>().levelBar.transform.localScale += new Vector3(0, exp / lvManager.GetComponent<LevelManager>().expLimit * 360, 0);
            enemystate = ENEMYSTATE.DEAD;
            //enemystate = ENEMYSTATE.ATTACK;
        }
        if(unitIn==true)
        {
            if (col.gameObject.tag == "Unit1")
            {
                unit = col.gameObject;
                enemystate = ENEMYSTATE.ATTACK;
            }
        }
    }
}
