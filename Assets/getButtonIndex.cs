using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getButtonIndex : MonoBehaviour {
    public ButtonManager bm;

    private void Start()
    {
        bm = GameObject.Find("ButtonManager").GetComponent<ButtonManager>();
    }

    void OnClick()
    {
        gameObject.AddChild(bm.selector);
        Destroy(bm.selector);
        bm.selector = gameObject.transform.GetChild(0).gameObject;
    }
}
