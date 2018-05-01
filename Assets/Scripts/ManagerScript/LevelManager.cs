using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public UILabel levelLabel;
    public float expVaule;
    public float levelVaule;
    public float expLimit;
    public GameObject levelBar;
	void Start ()
    {
		
	}
	
	void Update ()
    {
        if(expVaule>=expLimit)
        {
            expVaule = 0;
            levelVaule += 1;
            levelBar.transform.localScale = new Vector3(360,0,360);
            expLimit += 100;
        }
        levelLabel.text = "Lv."+levelVaule.ToString();
	}
}
