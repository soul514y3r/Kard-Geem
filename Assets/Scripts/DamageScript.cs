using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] float TotalHealth;
    public Classes classes;
    public EnemyScript enemyScript;
    public float CurrHealth;
    
    float Resistance = 1;


      //Checkar om objektet är en spelare eller fiende och tar den maximala HP för att sätta HP till det I början.
    public void HealthSet()
    {
        if (gameObject.tag =="Enemy") {TotalHealth = enemyScript.HP;}
        else if (TotalHealth == 0) {TotalHealth = classes.HP;}
        CurrHealth = TotalHealth;

        
    }

     //Funktion för att kunna ta skada och se om objektet är stark/svag emot den inkommande skadekällan.
 public void TakeDamage(float Damage, string DameType)
    {
        GetResistance(DameType);
        CurrHealth -= Damage * Resistance;

    }

     // kollar för att se om objektet är stark/svag emot en inkomande skadetyp.
    void GetResistance(string DamType)
    {
        if (gameObject.tag =="Enemy") {if (enemyScript.Resistance.Contains(DamType) == true){Resistance = 0.5f;}}
        else if (classes.Resistances.Contains(DamType) == true){Resistance = 0.5f;}

    }
}
