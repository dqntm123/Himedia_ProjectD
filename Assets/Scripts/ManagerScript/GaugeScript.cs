using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeScript : MonoBehaviour {

    public float coolTime1;
    public float coolTime2;
    public int[] gaugeValue;
    public int[] gaugeMaixmum;
    public float[] limit;
    public GameObject[] gaugeObj;
    public UILabel[] countLabel;
    public bool beefOn =true;
    public bool manaOn = true;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        if(gaugeValue[0]<gaugeMaixmum[0])
        {
            beefOn = true;
        }
        if (gaugeValue[1] < gaugeMaixmum[1])
        {
            manaOn = true;
        }
        if (beefOn == true)
        {
            coolTime1 += Time.deltaTime;
            if(coolTime1>=limit[0])
            {
                coolTime1 = 0;
                gaugeValue[0] += 1;
                if(gaugeValue[0]>=gaugeMaixmum[0])
                {
                    beefOn = false;
                }
            }
            countLabel[0].text = gaugeValue[0].ToString() + "/"+ gaugeMaixmum[0].ToString();

        }
        if (manaOn == true)
        {
            coolTime2 += Time.deltaTime;
            if(coolTime2>=limit[1])
            {
                coolTime2 = 0;
                gaugeValue[1] += 1;
                if (gaugeValue[1] >= gaugeMaixmum[1])
                {
                    manaOn = false;
                }
            }
            countLabel[1].text = gaugeValue[1].ToString() + "/" + gaugeMaixmum[1].ToString();
        }
	}
}
