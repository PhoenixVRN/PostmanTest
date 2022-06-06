using TMPro;
using UnityEngine;

public class Addres : MonoBehaviour
{
    public bool isClosed;
    
    private TextMeshPro _text;
    
    void Start()
    {
        _text = GetComponentInChildren<TextMeshPro>();
    }
    

    private void OnMouseDown()
    {
        if (isClosed)
        {
            _text.color = Color.green;
            isClosed = false;
        }
        else
        {
            _text.color = Color.red;
            isClosed = true;
        }
    }
}
