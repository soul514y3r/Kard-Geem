using Unity.VisualScripting;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] float TotalHealth;
    public Classes classes;
    public float CurrHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void HealthSet()
    {
        if (TotalHealth == 0) {TotalHealth = classes.HP;}
        CurrHealth = TotalHealth;
        
    }

 public void TakeDamage(float Damage)
    {
        CurrHealth -= Damage;
    }
}
