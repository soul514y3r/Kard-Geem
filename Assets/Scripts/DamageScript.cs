using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] float TotalHealth;
    public Classes classes;
    public float CurrHealth;
    
    float Resistance = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void HealthSet()
    {
        if (TotalHealth == 0) {TotalHealth = classes.HP;}
        CurrHealth = TotalHealth;

        
    }

 public void TakeDamage(float Damage, string DameType)
    {
        GetResistance(DameType);
        CurrHealth -= Damage * Resistance;

    }

    void GetResistance(string DamType)
    {
        if (classes.Resistances == DamType){Resistance = 0.5f;}

    }
}
