using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {

    public float unitSpeed;
    public float damage;
    public GameObject hpManager;
    public GameObject effect;
    public GameObject enemy;
    public float attackCool;
    public float attackResPawn;
    public bool enemyIn = true;
    public enum UNITSTATE
    {
        NONE,
        MOVE,
        ATTACK,
        DEAD
    }
    public UNITSTATE unitstate;

    void Start()
    {
        unitstate = UNITSTATE.NONE;
        hpManager = GameObject.Find("HPManager");
    }
    void Update()
    {
        switch (unitstate)
        {
            case UNITSTATE.NONE:
                
                break;
            case UNITSTATE.MOVE:
                gameObject.GetComponentInChildren<Animator>().SetBool("Attack", false);
                transform.Translate(unitSpeed * Time.deltaTime, 0, 0);
                break;
            case UNITSTATE.ATTACK:
                gameObject.GetComponentInChildren<Animator>().SetBool("Attack", true);
                attackCool += Time.deltaTime;
                if(attackCool>=attackResPawn)
                {
                    Instantiate(effect,transform.position, transform.rotation);
                    attackCool = 0;
                }
                break;
            case UNITSTATE.DEAD:
                gameObject.GetComponentInChildren<Animator>().SetBool("Die", true);
                Destroy(gameObject,0.65f);
                break;
            default:
                break;
        }
        if(enemyIn==null)
        {
            enemyIn = true;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Castle")
        {
            hpManager.GetComponent<HPManager>().castleGauge.transform.localScale -= new Vector3(damage/hpManager.GetComponent<HPManager>().castleHP*360, 0, 0);
            unitstate = UNITSTATE.DEAD;
            //unitstate = UNITSTATE.ATTACK;
        }
        if(enemyIn==true)
        {
            if (col.gameObject.tag == "Enemy1")
            {
                enemy = col.gameObject;
                unitstate = UNITSTATE.ATTACK;
                enemyIn = false;
            }
        }
    }
}
