using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string title { get; private set; }
    public string id { get; private set; }
    public int lv { get; private set; }
    public float currentExp { get; private set; }
    public float maxExp { get; private set; }
    public int gold { get; private set; }

    public float attack { get; private set; }
    public float defence { get; private set; }
    public float hp { get; private set; }
    public float strike { get; private set; }
    

    public Character()
    {
        title = "-";
        id = "Song";
        lv = 1;
        currentExp = 1;
        maxExp = 12;
        gold = 0;
        attack = 10f;
        defence = 5f;
        hp = 100f;
        strike = 0f;
    }
}
