using System;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] GameObject Name;
    [SerializeField] GameObject HP;
    [SerializeField] GameObject DMG;
    [SerializeField] GameObject DamType;
    [SerializeField] GameObject CharName;
    public Classes classes;
    public DamageScript damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        if (classes.HasRun == true){
        Name.GetComponent<TMP_Text>().SetText(classes.Name);
        HP.GetComponent<TMP_Text>().SetText("HP: "+ damage.CurrHealth.ToString());
        DMG.GetComponent<TMP_Text>().SetText("DMG: "+ classes.DMG.ToString());
        DamType.GetComponent<TMP_Text>().SetText("DamType: "+ classes.DamType);
        CharName.GetComponent<TMP_Text>().SetText(classes.CharName);
        }
    }

}
