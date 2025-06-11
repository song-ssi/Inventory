using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] public GameObject uiMainButton { get; private set;}
    [SerializeField] public GameObject uiStatus {get; private set;}
    [SerializeField] public GameObject uiInventory {get; private set;}
    
    UIMainMenu uiMainMenu;

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        uiMainMenu = FindObjectOfType<UIMainMenu>();
    }

    public void StatusButton()
    {
        uiMainMenu.OpenStatus();
    }
    
    public void InventoryButton()
    {
        uiMainMenu.OpenInventory();
    }
    public void BackButton()
    {
        uiMainMenu.OpenMainMenu();
    }
}
