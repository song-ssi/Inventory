using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] TextMeshProUGUI attackText;
    [SerializeField] TextMeshProUGUI defenceText;
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] TextMeshProUGUI strikeText;

    Character character;

    void Start()
    {
        backButton.onClick.AddListener(UIManager.Instance.uiMainMenu.OpenMainMenu);
        character = GameObject.Find("Character").GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowCharacterStatus();
    }

    void ShowCharacterStatus()
    {
        attackText.text = character.attack.ToString();
        defenceText.text = character.defence.ToString();
        hpText.text = character.hp.ToString();
        strikeText.text = character.strike.ToString();
    }
}
