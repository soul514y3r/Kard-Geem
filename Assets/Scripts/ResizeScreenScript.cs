using UnityEngine;

public class ResizeScreenScript : MonoBehaviour
{

    public GameObject Object;
    //Ser till att bakgrunden är tillräckligt stor
    void Start()
    {
        Object.GetComponent<RectTransform>();
        Object.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height); 
    }
}
