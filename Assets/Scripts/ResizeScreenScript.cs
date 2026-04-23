using UnityEngine;

public class ResizeScreenScript : MonoBehaviour
{

    public GameObject Object;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Object.GetComponent<RectTransform>();
        Object.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height); 
    }
}
