using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour {

    public GameObject minionPanel;
    public GameObject shopPanel;
    public GameObject weaponPanel;

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Stage()
    {
        SceneManager.LoadScene(2);
    }

    public void Minion()
    {
        if (shopPanel.activeSelf == true)
        {
            shopPanel.SetActive(false);
        }
        if (weaponPanel.activeSelf == true)
        {
            weaponPanel.SetActive(false);
        }
        minionPanel.SetActive(true);
    }

    public void Shop()
    {
        if (minionPanel.activeSelf == true)
        {
            minionPanel.SetActive(false);
        }
        if (weaponPanel.activeSelf == true)
        {
            weaponPanel.SetActive(false);
        }
        shopPanel.SetActive(true);
    }

    public void weapon()
    {
        if (shopPanel.activeSelf == true)
        {
            shopPanel.SetActive(false);
        }
        if (minionPanel.activeSelf == true)
        {
            minionPanel.SetActive(false);
        }
        weaponPanel.SetActive(true);
    }
}
