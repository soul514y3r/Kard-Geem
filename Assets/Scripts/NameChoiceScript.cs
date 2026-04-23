using UnityEngine;

public class NameChoiceScript : MonoBehaviour
{
    public string Name;
    
    //Namnet du skriver in blir sedan skickat till Classes skriptet
public void ChooseName(string name)
    {
        Name = name;
        Debug.Log("your new name is: " + Name);
    }
}
