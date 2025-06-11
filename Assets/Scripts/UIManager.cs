using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] public GameObject uiMainButton;

    [SerializeField] public GameObject uiStatus;
    [SerializeField] public GameObject uiInventory;
    
    public UIMainMenu uiMainMenu;

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

}
