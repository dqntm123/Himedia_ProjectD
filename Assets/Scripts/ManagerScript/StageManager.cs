using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {

	
    public void Stage1()
    {
        SceneManager.LoadScene(1);
    }
    public void Stage2()
    {
        SceneManager.LoadScene(2);
    }
}
