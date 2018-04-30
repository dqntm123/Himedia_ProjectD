using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour {

    public GameObject bullet;
	
	public void BulletBTN()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
