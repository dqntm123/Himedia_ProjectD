using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour {

    public GameObject[] skill;

    public void SkillOneIns()
    {
        Instantiate(skill[0], transform.position, transform.rotation);
    }
}
