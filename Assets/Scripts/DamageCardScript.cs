using UnityEngine;

public class DamageCardScript : MonoBehaviour
{
    DamageScript damageScript;
    public Classes classes;
    public GameObject Enemy;
    public GameObject Player;

    //Skadar fienden med skadetypen som spelarens klass har och förstör sedan kortet.
public void CardDamage()
    {
        Player = GameObject.Find("Player");
        classes = Player.GetComponent<Classes>();
        Enemy = GameObject.FindWithTag("Enemy");
        damageScript = Enemy.GetComponent<DamageScript>();
        damageScript.TakeDamage(10, classes.DamType);
        Destroy(gameObject);
    }
}
