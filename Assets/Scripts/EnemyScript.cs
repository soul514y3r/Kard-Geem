using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
  public float HP;
  public float DMG;

  public string DamType;

  public string[] Resistance;


  public GameObject Player;
    [SerializeField] GameObject Hp;
    [SerializeField] GameObject Damage;
    [SerializeField] GameObject DamageType;
  DamageScript damage;
  DamageScript DamageSelf;

     //Instatierar variabler när skriptet lässes in.
    void Awake()
    {
        Player = GameObject.Find("Player");
        damage = Player.GetComponent<DamageScript>();
        DamageSelf = gameObject.GetComponent<DamageScript>();
    }

        //Varje frame så uppdaterar fiendens stats och UI
    void Update()
    {
        Hp.GetComponent<TMP_Text>().SetText("HP: "+ DamageSelf.CurrHealth.ToString());
        Damage.GetComponent<TMP_Text>().SetText("DMG: "+ DMG.ToString());
        DamageType.GetComponent<TMP_Text>().SetText("DamType: "+ DamType);
        if (DamageSelf.CurrHealth <= 0) {SceneManager.LoadScene(sceneName:"Winscreen", LoadSceneMode.Single);}
    }

         //Skadar spelaren
    public void TakeTurn()
    {
        damage.TakeDamage(DMG, DamType);
    }
}
