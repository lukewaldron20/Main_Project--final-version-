﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Note")]
public class Card : ScriptableObject
{

    public new string name;
    public string description;

    public void Print()
    {
        Debug.Log(name + ":" + description);
    }
}