using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Classes : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        public string Name;
        public float HP;
        public float DMG;
        public string DamType;

        public StartGameScript script;
        public string CharName;

    void Awake()
    {
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
        }
        if (script.RoleInt == 1)
        {
            Name = "Mage";
            HP = 20;
            DMG = 25;
            DamType = "Energy";
        }
        if (script.RoleInt == 2)
        {
            Name = "Fighter";
            HP = 35;
            DMG = 15;
            DamType = "Physical";
        } 
    }

}
