using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Classes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        public string Name;
        public float HP;
        public float DMG;
        public string DamType;
        public bool HasRun;

        public StartGameScript script;
        public string CharName;

        public DamageScript damage;
        public List<string> Resistances = new List<string>();
        public List<string> Weaknesses = new List<string>();

    

    void Awake()
    {
        HasRun = false;
        DontDestroyOnLoad(gameObject);
    }

    public void SetClass()
    {
        CharName = script.Name;
        if (script.RoleInt == 0)
        {
            Name = "Knight";
            HP = 45;
            DMG = 10;
            DamType = "Physical";
            Resistances.Add("Physical");
        }
        if (script.RoleInt == 1)
        {
            Name = "Mage";
            HP = 20;
            DMG = 25;
            DamType = "Energy";
            Resistances.Add("Energy");
        }
        if (script.RoleInt == 2)
        {
            Name = "Fighter";
            HP = 35;
            DMG = 15;
            DamType = "Physical";
            Resistances.Add("Psychic");
        } 
        damage.HealthSet();
        HasRun = true;
    }

}
