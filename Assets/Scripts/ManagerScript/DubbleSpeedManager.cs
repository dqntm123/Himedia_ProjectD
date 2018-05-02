using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DubbleSpeedManager : MonoBehaviour {

    public GameObject[] speedObj;
	
    public void TwoSpeed()
    {
        speedObj[0].SetActive(false);
        speedObj[1].SetActive(true);
        speedObj[2].SetActive(false);
        Time.timeScale = 2f;
    }
    public void ThreeSpeed()
    {
        speedObj[0].SetActive(false);
        speedObj[1].SetActive(false);
        speedObj[2].SetActive(true);
        Time.timeScale = 3f;
    }
    public void NormalSpeed()
    {
        speedObj[0].SetActive(true);
        speedObj[1].SetActive(false);
        speedObj[2].SetActive(false);
        Time.timeScale=1f;
    }
}
