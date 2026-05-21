using Unity.VisualScripting;
using UnityEngine;

public class GenerateMatchScript : MonoBehaviour
{
    [SerializeField] int DeckMax;
    GameObject Player;
    RandomCardScript rando;
    
    //Finner spelaren och kortkomponenten
    void Awake()
    {
        Player = GameObject.Find("Player");
        rando = Player.GetComponent<RandomCardScript>();
    }

    //sätter en random mängd kort I din hand.
    public void Generate()
    {
    DeckMax = UnityEngine.Random.Range(10, 25);
    rando.DeckMax = DeckMax;
    }
}
