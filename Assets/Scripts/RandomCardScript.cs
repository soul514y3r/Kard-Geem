using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomCardScript : MonoBehaviour
{
    public GameObject CardPlacement1;
    public GameObject CardPlacement2;
    public GameObject CardPlacement3;
    public GameObject CardPlacement4;
    public GameObject CardPlacement5;
    public GameObject CardDamage;
    public GameObject CardResisto;
    public GameObject Player;
    public int DeckSize;
    public int DeckMax;
    float randint;
    string Defeat;
    PlayerUI UI;
    GameObject Card;
    

    // Skapar en random storlek på kortleken och skickar det till UIn. Läser in olika komponenter och object i skriptet.
        void Awake()
    {
        Player = GameObject.Find("Player");
        Defeat = "DefeatScreen";
        UI = Player.GetComponent<PlayerUI>();
        DeckMax = UnityEngine.Random.Range(10, 25);
        UI.DeckCurr = DeckMax - DeckSize;
    }

         //Skapar ett random kort och placerar det som ett barn till ett objekt.
    void randCard(GameObject self, Vector2 Pos)
    {
        randint = UnityEngine.Random.Range(1, 3); 
        if (randint == 1)
        {
         Card = Instantiate(CardDamage, new Vector3(0,0, -1), quaternion.AxisAngle(0,0), self.transform);
         Card.GetComponent<RectTransform>().anchoredPosition = Pos;
         DeckSize += 1;
        }
        if (randint == 2)
        {
         Card = Instantiate(CardResisto, new Vector3(0,0, -1), quaternion.AxisAngle(0,0), self.transform);
         Card.GetComponent<RectTransform>().anchoredPosition = Pos;
         DeckSize += 1;
        }
    }

        //Skapar ett kort ifall platsen är tom.
 public void Shuffle()
    {

        if (CardPlacement5.transform.childCount == 0)
         randCard(CardPlacement5, new Vector2(-100, -182));
        if (CardPlacement4.transform.childCount == 0)
         randCard(CardPlacement4, new Vector2(-200, -182));
        if (CardPlacement3.transform.childCount == 0)
         randCard(CardPlacement3, new Vector2(-300, -182));
        if (CardPlacement2.transform.childCount == 0)
         randCard(CardPlacement2, new Vector2(-400, -182));
        if (CardPlacement1.transform.childCount == 0)
         randCard(CardPlacement1, new Vector2(-500, -182));
        Debug.Log(DeckSize);
        UI.DeckCurr = DeckMax - DeckSize;
        if (DeckSize > DeckMax) 
         SceneManager.LoadScene(Defeat, LoadSceneMode.Single);
    }
}
