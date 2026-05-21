using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] GameObject Name;
    [SerializeField] GameObject HP;
    [SerializeField] GameObject DMG;
    [SerializeField] GameObject DamType;
    [SerializeField] GameObject CharName;
    [SerializeField] GameObject DeckSize;
    public Classes classes;
    public DamageScript damage;
    public int DeckCurr;




    //När Classes skriptet har kört, uppdaterar skriptet dina stats.
    void Update()
    {
        if (classes.HasRun == true){
        Name.GetComponent<TMP_Text>().SetText(classes.Name);
        HP.GetComponent<TMP_Text>().SetText("HP: "+ damage.CurrHealth.ToString());
        DMG.GetComponent<TMP_Text>().SetText("DMG: "+ classes.DMG.ToString());
        DamType.GetComponent<TMP_Text>().SetText("DamType: "+ classes.DamType);
        CharName.GetComponent<TMP_Text>().SetText(classes.CharName);
        DeckSize.GetComponent<TMP_Text>().SetText("DeckSize: "+ DeckCurr);
        if (damage.CurrHealth == 0) {SceneManager.LoadScene("DefeatScreen", LoadSceneMode.Single);}
        }
    }

}
