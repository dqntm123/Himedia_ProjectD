using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapScripts : MonoBehaviour {

    public float miniSP;
    public GameObject player;
    public Vector3 miniPos;
    public enum MINIMAPSTATE
    {
        NONE,
        RIGHT,
        LEFT
    }
    public MINIMAPSTATE minimapstate;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        miniPos = transform.position;
        switch (minimapstate)
        {
            case MINIMAPSTATE.NONE:

                break;
            case MINIMAPSTATE.RIGHT:
                if (player.GetComponent<PlayerController>().playstate == PlayerController.PLAYSTATE.NONE)
                {
                    minimapstate = MINIMAPSTATE.NONE;
                }
                transform.Translate(miniSP * Time.deltaTime, 0, 0);
                break;
            case MINIMAPSTATE.LEFT:
                if (player.GetComponent<PlayerController>().playstate == PlayerController.PLAYSTATE.NONE)
                {
                    minimapstate = MINIMAPSTATE.NONE;
                }
                transform.Translate(-miniSP * Time.deltaTime, 0, 0);
                break;
            default:
                break;
        }
    }
    public void RightMV()
    {
        minimapstate = MINIMAPSTATE.RIGHT;
    }
    public void LeftMV()
    {
        minimapstate = MINIMAPSTATE.LEFT;
    }
    public void NoneSTA()
    {
        minimapstate = MINIMAPSTATE.NONE;
    }
}
