using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour {

    public GameObject[] skill;
    public float[] skillgauge;
    public float[] summonSkill;
    public GameObject gaugeManager;
    public GameObject skillAnimtor;

    void Start()
    {
        gaugeManager = GameObject.Find("GaugeManager");
    }
    public void SkillOneIns()
    {
        if(gaugeManager.GetComponent<GaugeScript>().gaugeValue[1]>=skillgauge[0])
        {
            skillAnimtor.GetComponent<Animator>().SetBool("Skill", true);
            Instantiate(skill[0], transform.position, transform.rotation);
            gaugeManager.GetComponent<GaugeScript>().gaugeValue[1] -= summonSkill[0];
            gaugeManager.GetComponent<GaugeScript>().gaugeBar[1].transform.localScale -= new Vector3(summonSkill[0] / gaugeManager.GetComponent<GaugeScript>().gaugeMaixmum[1]*360, 0, 0);
        }
    }
}
