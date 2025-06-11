using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float attack;
    public float defence;
    public float hp;
    public float strike;

    public Character()
    {
        attack = 10f;
        defence = 5f;
        hp = 100f;
        strike = 0f;
    }
}
