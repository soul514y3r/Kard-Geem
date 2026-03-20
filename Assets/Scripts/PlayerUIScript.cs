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
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        Name.GetComponent<TMP_Text>().SetText(classes.Name);
        HP.GetComponent<TMP_Text>().SetText(classes.HP.ToString());
        DMG.GetComponent<TMP_Text>().SetText(classes.DMG.ToString());
        DamType.GetComponent<TMP_Text>().SetText(classes.DamType);
        CharName.GetComponent<TMP_Text>().SetText(classes.CharName);
    }
}
