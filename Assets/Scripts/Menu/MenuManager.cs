using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public GameObject optionPanel;

    public void OptionBtn()
    {
        optionPanel.SetActive(true);
    }

    public void OptionXBtn()
    {
        optionPanel.SetActive(false);
    }


    public UISlider effectSlider;
    public UISlider musicSlider;

    public void EffectVolumePlus()
    {
        if(effectSlider.value < 1)
        {
            effectSlider.value += 0.2f;
        }
    }

    public void EffectVolumeMinus()
    {
        if (effectSlider.value > 0)
        {
            effectSlider.value -= 0.2f;
        }
    }

    public void MusicVolumePlus()
    {
        if (musicSlider.value < 1)
        {
            musicSlider.value += 0.2f;
        }
    }

    public void MusicVolumeMinus()
    {
        if (musicSlider.value > 0)
        {
            musicSlider.value -= 0.2f;
        }
    }
}
