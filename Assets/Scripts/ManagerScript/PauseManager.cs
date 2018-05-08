using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

    public GameObject pausePopUp;

	public void PopUpOn()
    {
        pausePopUp.SetActive(true);
        Time.timeScale = 0;
    }
    public void PopUpOff()
    {
        pausePopUp.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainScence()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
