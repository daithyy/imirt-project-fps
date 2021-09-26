using System;
using UnityEngine;

[Serializable]
public class SaveDataFPS
{
    public float currentHealth;

    public SaveDataFPS(float currentHealth)
    {
        this.currentHealth = currentHealth;
    }
}