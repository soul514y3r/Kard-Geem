using TMPro;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
  public float HP;
  public float DMG;

  public string DamType;

  public GameObject Player;
    [SerializeField] GameObject Hp;
    [SerializeField] GameObject Damage;
    [SerializeField] GameObject DamageType;
  DamageScript damage;

    void Awake()
    {
        Player = GameObject.Find("Player");
        damage = Player.GetComponent<DamageScript>();
    }

    void Update()
    {
        Hp.GetComponent<TMP_Text>().SetText("HP: "+ HP.ToString());
        Damage.GetComponent<TMP_Text>().SetText("DMG: "+ DMG.ToString());
        DamageType.GetComponent<TMP_Text>().SetText("DamType: "+ DamType);
    }

    public void TakeTurn()
    {
        damage.TakeDamage(DMG, DamType);
    }
}
