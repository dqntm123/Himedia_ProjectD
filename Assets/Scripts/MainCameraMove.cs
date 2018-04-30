using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMove : MonoBehaviour {


    public float cameraSP;
    public float limit;
    public enum CAMERASTATE
    {
        NONE,
        RIGHT,
        LEFT
    }
    public CAMERASTATE camerastate;

    void Start()
    {
        
    }

    void Update()
    {
        switch (camerastate)
        {
            case CAMERASTATE.NONE:
                break;
            case CAMERASTATE.RIGHT:
                transform.Translate(cameraSP * Time.deltaTime, 0, 0);
                break;
            case CAMERASTATE.LEFT:
                transform.Translate(-cameraSP * Time.deltaTime, 0, 0);
                break;
            default:
                break;
        }
        if (transform.position.x>3.2f)
        {
            transform.position = new Vector3(3.2f,0,-4);
        }
        if (transform.position.x <0 )
        {
            transform.position = new Vector3(0,0,-4);
        }
    }

}
