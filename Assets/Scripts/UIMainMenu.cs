using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button statusButton;
    [SerializeField] Button inventoryButton;

    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI idText;
    [SerializeField] TextMeshProUGUI lvText;
    [SerializeField] TextMeshProUGUI expText;
    [SerializeField] Image expBar;
    [SerializeField] TextMeshProUGUI goldText;

    UIManager uimanager;
    Character character;

    void Start()
    {
      uimanager = UIManager.Instance;
      character =  FindObjectOfType<Character>();
      statusButton.onClick.AddListener(OpenStatus);
      inventoryButton.onClick.AddListener(OpenInventory);
      OpenMainMenu();
    }

    void Update()
    {
        ShowCharacterInfo();    
    }

    void ShowCharacterInfo()
    {
        titleText.text = character.title;
        idText.text = character.id;
        lvText.text = character.lv.ToString();
        expText.text = $"{character.currentExp} / {character.maxExp}";
        goldText.text = character.gold.ToString();
    }


    // 메인메뉴 열기
    public void OpenMainMenu()
    {
        uimanager.uiMainButton.SetActive(true);
        uimanager.uiStatus.SetActive(false);
        uimanager.uiInventory.SetActive(false);
    }

    // 상태창 열기
    public void OpenStatus()
    {
        uimanager.uiMainButton.SetActive(false);
        uimanager.uiStatus.SetActive(true);
    }

    // 인벤토리 열기
    public void OpenInventory()
    {
       uimanager.uiMainButton.SetActive(false);
        uimanager.uiInventory.SetActive(true);
    }
}
