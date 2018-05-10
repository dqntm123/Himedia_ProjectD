using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {

    public GameObject slot;
    public List<GameObject> Items;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}


    public void OnTriggerEnter(Collider col)
    {
        
        if(col.gameObject.tag == "item")
        {
            Items.Add(col.gameObject);
            Items[0].transform.SetParent(slot.transform);
            Items[0].transform.position = gameObject.transform.position;
        }

    }

    public void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "item")
        {
            Items.RemoveAt(0);
        }

    }

}
