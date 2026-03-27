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
    float randint;
    RectTransform pos;
    GameObject Card;
    
    //int CurrCards;
    //List<GameObject> CardAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void randCard(GameObject self, Vector2 Pos)
    {
        randint = UnityEngine.Random.Range(1, 3); 
        if (randint == 1)
        {
         Card = Instantiate(CardDamage, new Vector3(0,0, -1), quaternion.AxisAngle(0,0), self.transform);
         Card.GetComponent<RectTransform>().anchoredPosition = Pos;
        }
        if (randint == 2)
        {
         Card = Instantiate(CardResisto, new Vector3(0,0, -1), quaternion.AxisAngle(0,0), self.transform);
         Card.GetComponent<RectTransform>().anchoredPosition = Pos;
        }
    }

    // Update is called once per frame
 public void Shuffle()
    {
        //CardAmount.Add(CardPlacement5);
        //CardAmount.Add(CardPlacement4);
        //CardAmount.Add(CardPlacement3);
        //CardAmount.Add(CardPlacement2);
        //CardAmount.Add(CardPlacement1);
        //try{CardAmount.AddRange(Card);}
        //catch(NullReferenceException)
        //{Debug.Log("No active Cards");}
        
        
        
        //CardAmount.RemoveRange(0, CurrCards);
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
    }
}
