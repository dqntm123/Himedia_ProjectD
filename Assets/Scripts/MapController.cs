using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

    public float mapSP;
    public GameObject player;
    public enum MAPSTATE
    {
        NONE,
        RIGHT,
        LEFT
    }
    public MAPSTATE mapstate;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update ()
    {
        switch (mapstate)
        {
            case MAPSTATE.NONE:
                break;
            case MAPSTATE.RIGHT:
                transform.Translate(-mapSP * Time.deltaTime, 0, 0);
                break;
            case MAPSTATE.LEFT:
                transform.Translate(mapSP * Time.deltaTime, 0, 0);
                break;
            default:
                break;
        }
        if (transform.localPosition.x > 580)
        {
            transform.localPosition = new Vector3(580, 60, 0);
        }
        if (transform.localPosition.x < -570)
        {
            transform.localPosition = new Vector3(-570, 60, 0);
        }
    }
}
