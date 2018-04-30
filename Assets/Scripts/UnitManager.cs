using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour {


    public GameObject unit;
    public GameObject[] enableChang;
    public float coolT;
    public float resPawnT;
    public bool unitIns = false;

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
    public void UnitINS()
    {
        Instantiate(unit, transform.position, transform.rotation);
        unitIns = true;
        enableChang[0].GetComponent<UIButton>().enabled = false;
        enableChang[1].SetActive(true);
    }
}
