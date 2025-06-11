using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    UIManager uimanager;

    void Start()
    {
      uimanager = UIManager.Instance;
    }
    public void OpenMainMenu()
    {
        uimanager.uiMainButton.SetActive(true);
        uimanager.uiStatus.SetActive(false);
        uimanager.uiInventory.SetActive(false);
    }

    public void OpenStatus()
    {
        uimanager.uiMainButton.SetActive(false);
        uimanager.uiStatus.SetActive(true);
    }

    public void OpenInventory()
    {
        uimanager.uiMainButton.SetActive(false);
        uimanager.uiInventory.SetActive(true);
    }
}
