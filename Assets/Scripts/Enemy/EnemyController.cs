using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {


    public float enemySP;
    public GameObject lvManager;
    public int exp;
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
            enemystate = ENEMYSTATE.DEAD;
        }
    }
}
