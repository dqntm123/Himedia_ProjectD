using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour {

    public GameObject[] skill;
    public int[] skillgauge;
    public GameObject gaugeManager;

    void Start()
    {
        gaugeManager = GameObject.Find("GaugeManager");
    }
    public void SkillOneIns()
    {
        if(gaugeManager.GetComponent<GaugeScript>().gaugeValue[1]>=skillgauge[0])
        {
            Instantiate(skill[0], transform.position, transform.rotation);
            gaugeManager.GetComponent<GaugeScript>().gaugeValue[1] -= 10;
        }
    }
}
