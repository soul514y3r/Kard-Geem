using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] int MaxHealth;
    public Classes classes;
    public EnemyScript enemyScript;
    public int CurrHealth;
    
    float Resistance = 1;

          //Om hälsan ska läggas till på en fiende, ska den randomizas. Lägger sedan till MaxHP till din HP pool.
    void Awake()
    {
        if (gameObject == GameObject.Find("Enemy")) {MaxHealth = UnityEngine.Random.Range(20, MaxHealth); Debug.Log("Here");}
        CurrHealth = MaxHealth;
    }


    //Checkar om objektet är en spelare eller fiende och tar den maximala HP för att sätta HP till det I början.
    public void HealthSet()
    {
        if (gameObject == GameObject.Find("Player")) {MaxHealth = Convert.ToInt32(classes.HP);}
        Debug.Log(MaxHealth);
        CurrHealth = MaxHealth;

        
    }

     //Funktion för att kunna ta skada och se om objektet är stark/svag emot den inkommande skadekällan.
 public void TakeDamage(float Damage, string DameType)
    {
        GetResistance(DameType);
        CurrHealth -= Convert.ToInt32(Damage * Resistance);

    }

     // kollar för att se om objektet är stark/svag emot en inkomande skadetyp.
    void GetResistance(string DamType)
    {
        if (gameObject.tag =="Enemy") {if (enemyScript.Resistance.Contains(DamType) == true){Resistance = 0.5f;}}
        else if (classes.Resistances.Contains(DamType) == true){Resistance = 0.5f;}

    }
}
