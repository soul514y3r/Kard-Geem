using System.Linq;
using System.Net.NetworkInformation;
using UnityEngine;

public class ResistoCardScript : MonoBehaviour
{
    public Classes classes;
    public GameObject Enemy;
    public GameObject Player;

    //Lägger till physical resistans om du inte redan hade det.
public void ResistoCard()
    {
        Player = GameObject.Find("Player");
        classes = Player.GetComponent<Classes>();
        Enemy = GameObject.FindWithTag("Enemy");
        if (classes.Resistances.Contains("Physical") == false) {classes.Resistances.Add("Physical");}
        if (classes.Resistances.Contains("Energy") == false) {classes.Resistances.Add("Energy");}
        if (classes.Resistances.Contains("Psychic") == false) {classes.Resistances.Add("Physical");}

        Destroy(gameObject);
    }
}
