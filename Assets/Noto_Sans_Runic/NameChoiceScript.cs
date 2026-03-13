using UnityEngine;

public class NameChoiceScript : MonoBehaviour
{
    public string Name;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public void ChooseName(string name)
    {
        Name = name;
        Debug.Log("your new name is: " + Name);
    }
}
