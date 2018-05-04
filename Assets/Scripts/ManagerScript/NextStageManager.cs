using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStageManager : MonoBehaviour {

    public GameObject[] nextStage;

    public void MainStage1()
    {
        nextStage[0].SetActive(true);
        nextStage[1].SetActive(false);
    }
    public void MainStage2()
    {
        nextStage[0].SetActive(false);
        nextStage[1].SetActive(true);
    }
}
