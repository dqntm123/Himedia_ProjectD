using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour {

    public GameObject[] unitS;
    public List<GameObject> unitMove;
    public GameObject[] enableChang;
    public GameObject gaugeMG;
    public float[] summonCost;
    public float[] unitVaule;
    public float coolT;
    public float resPawnT;
    public bool unitIns = false;

    void Start()
    {
        gaugeMG = GameObject.Find("GaugeManager");
        unitMove = new List<GameObject>();
        Instantiate(unitS[0], transform.position, transform.rotation);
        unitMove.Add(GameObject.Find("Unit1(Clone)"));
        unitMove[0].name = "Unit1";
    }
    void Update()
    {
        if(unitIns==true)
        {
            coolT += Time.deltaTime;
            if(coolT>resPawnT)
            {
                coolT = 0;
                enableChang[1].GetComponent<UISprite>().fillAmount -= 0.05f;
                if(enableChang[1].GetComponent<UISprite>().fillAmount==0)
                {
                    unitIns = true;
                    enableChang[0].GetComponent<UIButton>().enabled = true;
                    enableChang[1].GetComponent<UISprite>().fillAmount = 1;
                    enableChang[1].SetActive(false);
                    unitIns = false;
                }
            }
        }   
    }
    IEnumerator Unit1()
    {
        unitMove[0].GetComponent<UnitController>().unitstate = UnitController.UNITSTATE.MOVE;
        unitMove.RemoveAt(0);
        Instantiate(unitS[0],transform.position, transform.rotation);
        unitMove.Add(GameObject.Find("Unit1(Clone)"));
        unitMove[0].name = "Unit1";
        yield return null;
    }
    public void UnitINS()
    {
        if(gaugeMG.GetComponent<GaugeScript>().gaugeValue[0]>=unitVaule[0])
        {
            gaugeMG.GetComponent<GaugeScript>().gaugeValue[0] -= summonCost[0];
            gaugeMG.GetComponent<GaugeScript>().gaugeBar[0].transform.localScale -= new Vector3(summonCost[0]/gaugeMG.GetComponent<GaugeScript>().gaugeMaixmum[0]*360, 0,0);
            StartCoroutine(Unit1());
            unitIns = true;
            enableChang[0].GetComponent<UIButton>().enabled = false;
            enableChang[1].SetActive(true);
        }
    }
}
