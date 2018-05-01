using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public UILabel levelLabel;
    public int expVaule;
    public int levelVaule;
    public int expLimit;
	void Start ()
    {
		
	}
	
	void Update ()
    {
        if(expVaule>=expLimit)
        {
            expVaule = 0;
            levelVaule += 1;
            expLimit += 500;
        }
        levelLabel.text = levelVaule.ToString();
	}
}
