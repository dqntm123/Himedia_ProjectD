using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameObject mapObj;
    public bool right2 = false;
    public bool left2 = false;
    public enum PLAYSTATE
    {
        NONE,
        RIGHT,
        LEFT,
        DEAD
    }
    public PLAYSTATE playstate;

	void Start ()
    {
        mapObj = GameObject.Find("BG");
	}
	
	
	void Update ()
    {
        switch (playstate)
        {
            case PLAYSTATE.NONE:
                
                break;
            case PLAYSTATE.RIGHT:
                if(right2==false)
                {
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                    if (transform.position.x > -0.7f)
                    {
                        mapObj.GetComponent<MapController>().mapstate = MapController.MAPSTATE.RIGHT;
                    }
                }
                if(right2==true)
                {
                    left2 = false;
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                    mapObj.GetComponent<MapController>().mapstate = MapController.MAPSTATE.RIGHT;
                    if (transform.position.x > 0.7)
                    {
                        transform.position = new Vector3(0.7f, 0.2f, -0.2f);
                    }
                }
                break;
            case PLAYSTATE.LEFT:
                if(left2==false)
                {
                    transform.Translate(-speed * Time.deltaTime, 0, 0);
                    if (transform.position.x < -1f)
                    {
                        mapObj.GetComponent<MapController>().mapstate = MapController.MAPSTATE.LEFT;
                    }
                }
                if(left2==true)
                {
                    right2 = false;
                    transform.Translate(-speed * Time.deltaTime, 0, 0);
                    mapObj.GetComponent<MapController>().mapstate = MapController.MAPSTATE.LEFT;
                    if (transform.position.x < -1.7f)
                    {
                        transform.position = new Vector3(-1.7f, 0.2f, -0.2f);
                    }
                }
                break;
            case PLAYSTATE.DEAD:

                break;
            default:
                break;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Block1")
        {
            right2 = true;
        }
        if (col.gameObject.tag == "Block2")
        {
            left2 = true;
        }
    }
    public void RightMove()
    {
        playstate=PLAYSTATE.RIGHT;
    }
    public void LeftMove()
    {
        playstate = PLAYSTATE.LEFT;
    }
    public void NoneState()
    {
        playstate = PLAYSTATE.NONE;
        mapObj.GetComponent<MapController>().mapstate = MapController.MAPSTATE.NONE;
    }
}
