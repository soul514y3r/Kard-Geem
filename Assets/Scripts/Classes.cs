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

        SpriteRenderer sprite;
        [SerializeField] Sprite MageSprite;
        [SerializeField] Sprite FighterSprite;
        [SerializeField] Sprite KnightSprite;

    
        //Ser till att spelaren alltid finns kvar och hittar spriteRender componenten.
    void Awake()
    {
        HasRun = false;
        DontDestroyOnLoad(gameObject);
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }
    
       //Tar Klassvalet från dropdown, sedan ser den till att spelaren får attributen och rätt sprite.
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
            sprite.sprite = KnightSprite;
            gameObject.transform.localScale = new Vector3(0.3f,0.4f,1);
        }
        if (script.RoleInt == 1)
        {
            Name = "Mage";
            HP = 20;
            DMG = 25;
            DamType = "Energy";
            Resistances.Add("Energy");
            sprite.sprite = MageSprite;
            gameObject.transform.localScale = new Vector3(0.7f,0.7f,1);
        }
        if (script.RoleInt == 2)
        {
            Name = "Fighter";
            HP = 35;
            DMG = 15;
            DamType = "Physical";
            Resistances.Add("Psychic");
            sprite.sprite = FighterSprite;
            gameObject.transform.localScale = new Vector3(0.3f,0.3f,1);
        } 
        damage.HealthSet();
        HasRun = true;
    }

}
