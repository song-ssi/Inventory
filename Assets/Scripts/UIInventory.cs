using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] Button backButton;
    void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.uiMainMenu.OpenMainMenu);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
