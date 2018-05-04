using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public GameObject[] cameraObj;
    public GameObject hpMg;
    public bool right2 = false;
    public bool left2 = false;
    public Transform[] block;
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
        cameraObj[0] = GameObject.Find("Main Camera");
        cameraObj[1] = GameObject.Find("MiniPlayer");
        hpMg = GameObject.Find("HPManager");
    }
	
	void Update ()
    {
        
        switch (playstate)
        {
            case PLAYSTATE.NONE:
                transform.rotation = new Quaternion(0, 0, 0, 0);
                gameObject.GetComponentInChildren<Animator>().SetBool("Right", false);
                break;
            case PLAYSTATE.RIGHT:
                if(right2==false)
                {
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                }
                if(right2==true)
                {
                    left2 = false;
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                    cameraObj[0].GetComponent<MainCameraMove>().camerastate = MainCameraMove.CAMERASTATE.RIGHT;
                    if (transform.position.x > 4)
                    {
                        playstate = PLAYSTATE.NONE;
                        transform.position = new Vector3(4, 0.2f, -0.2f);
                        cameraObj[1].GetComponent<MiniMapScripts>().minimapstate = MiniMapScripts.MINIMAPSTATE.NONE;
                    }
                }
                break;
            case PLAYSTATE.LEFT:
                if(left2==false)
                {
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                    if (transform.position.x < -1.7f)
                    {
                        transform.position = new Vector3(-1.7f, 0.2f, -0.2f);
                        playstate = PLAYSTATE.NONE;
                        cameraObj[1].GetComponent<MiniMapScripts>().minimapstate = MiniMapScripts.MINIMAPSTATE.NONE;
                    }
                }
                if(left2==true)
                {
                    right2 = false;
                    cameraObj[0].GetComponent<MainCameraMove>().camerastate = MainCameraMove.CAMERASTATE.LEFT;
                    transform.Translate(speed * Time.deltaTime, 0, 0);
                    if (transform.position.x < -1.7f)
                    {
                        transform.position = new Vector3(-1.7f, 0.2f, -0.2f);
                        playstate = PLAYSTATE.NONE;
                        cameraObj[1].GetComponent<MiniMapScripts>().minimapstate = MiniMapScripts.MINIMAPSTATE.NONE;
                    }
                }
                break;
            case PLAYSTATE.DEAD:
                Destroy(gameObject);
                break;
            default:
                break;
        }
        if (hpMg.GetComponent<HPManager>().playerGauge.transform.localScale.x <= 0)
        {
            playstate = PLAYSTATE.DEAD;
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
        gameObject.GetComponentInChildren<Animator>().SetBool("Right", true);
    }
    public void LeftMove()
    {
        playstate = PLAYSTATE.LEFT;
        transform.rotation = new Quaternion(0, -180, 0,0);
        gameObject.GetComponentInChildren<Animator>().SetBool("Right", true);
    }
    public void NoneState()
    {
        gameObject.GetComponentInChildren<Animator>().SetBool("Skill", false);
        playstate = PLAYSTATE.NONE;
        cameraObj[0].GetComponent<MainCameraMove>().camerastate = MainCameraMove.CAMERASTATE.NONE;
    }
}
