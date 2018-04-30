using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillOne : MonoBehaviour {

    public float bulletSP;


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
            Destroy(gameObject);
        }
    }
}
