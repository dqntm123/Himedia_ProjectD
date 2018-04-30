using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject enemy;
    public bool ins1 = true;
    public bool ins2 = false;
    public float cooltime;
    public float respawntime;
    public float coolt2;
    public float respawnt2;
	void Update ()
    {
        if(ins1==true)
        {
            cooltime += Time.deltaTime;
            if (cooltime > respawntime)
            {
                cooltime = 0;
                Instantiate(enemy, transform.position, transform.rotation);
                ins1 = false;
                ins2 = true;
            }
        }
        if (ins2 == true)
        {
            coolt2 += Time.deltaTime;
            if (coolt2 > respawnt2)
            {
                coolt2 = 0;
                Instantiate(enemy, transform.position, transform.rotation);
                ins1 = true;
                ins2 = false;
            }
        }
    }
}
