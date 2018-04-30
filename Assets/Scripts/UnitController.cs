using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {

    public float unitSpeed;
    public enum UNITSTATE
    {
        NONE,
        STOP,
        ATTACK,
        DEAD
    }
    public UNITSTATE unitstate;

    void Start()
    {
        
    }
    void Update()
    {
        switch (unitstate)
        {
            case UNITSTATE.NONE:
                transform.Translate(unitSpeed * Time.deltaTime, 0, 0);
                break;
            case UNITSTATE.STOP:

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
            unitstate = UNITSTATE.DEAD;
        }
    }
}
