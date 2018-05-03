using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {

    public float unitSpeed;
    public float damage;
    public GameObject hpManager;
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
                transform.Translate(unitSpeed * Time.deltaTime, 0, 0);
                break;
            case UNITSTATE.ATTACK:

                break;
            case UNITSTATE.DEAD:
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Castle")
        {
            hpManager.GetComponent<HPManager>().castleGauge.transform.localScale -= new Vector3(damage/hpManager.GetComponent<HPManager>().castleHP*360, 0, 0);
            unitstate = UNITSTATE.DEAD;
        }
    }
}
