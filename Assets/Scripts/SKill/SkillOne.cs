using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillOne : MonoBehaviour {

    public float bulletSP;
    public float damage;
    public GameObject hpMg;

    void Start()
    {
        hpMg = GameObject.Find("HPManager");
    }

    void Update()
    {
        transform.Translate(bulletSP * Time.deltaTime, 0, 0);
        if (transform.position.x > 5.5f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Castle")
        {
            hpMg.GetComponent<HPManager>().castle.transform.localScale -= new Vector3(damage / hpMg.GetComponent<HPManager>().castleHP*360, 0, 0);
            Destroy(gameObject);
        }
    }
}
