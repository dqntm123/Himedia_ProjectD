using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleController : MonoBehaviour {

    public enum CASTLESTATE
    {
        NONE,
        BOSS,
        DEAD
    }
    public CASTLESTATE castlestate;
    public GameObject hpMG;

	void Start ()
    {
        hpMG = GameObject.Find("HPManager");
	}
	
	void Update ()
    {
        switch (castlestate)
        {
            case CASTLESTATE.NONE:

                break;
            case CASTLESTATE.BOSS:

                break;
            case CASTLESTATE.DEAD:
                Destroy(gameObject);
                break;
            default:
                break;
        }
       if(hpMG.GetComponent<HPManager>().castleGauge.transform.localScale.x<=0)
        {
            castlestate = CASTLESTATE.DEAD;
        }
    }
}
