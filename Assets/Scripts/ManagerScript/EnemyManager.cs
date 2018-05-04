using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject enemy;
    public float cooltime;
    public float respawntime;
	void Update ()
    {
        cooltime += Time.deltaTime;
        if (cooltime > respawntime)
        {
            cooltime = 0;
            enemy.name = "Enemy1";
            Instantiate(enemy, transform.position, transform.rotation);
        }
    }
}
