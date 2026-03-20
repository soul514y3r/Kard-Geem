using System;
using TMPro;
using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameScript : MonoBehaviour
{
    public NameChoiceScript script;
    public GameObject Role;
    public Classes classes;
    public int RoleInt;
    public string Name;
        
    
    void Start()
    {
        
    }

    public void startGame()
    {
        RoleInt = Role.GetComponent<TMP_Dropdown>().value;

        Name = script.Name;
        Debug.Log("Your Name is: "+ Name);
        Debug.Log("Your Class is: "+ RoleInt);
        classes.SetClass();
        SceneManager.LoadScene("Match", LoadSceneMode.Single);
    }

}
