using UnityEngine;

public class ColorManager : MonoBehaviour
{
    private Renderer objectRenderer;
    private void OnEnable()
    {
        MouseBroadcast.OnMouseClick += ChangeColor;
    }

    private void OnDisable()
    {
        MouseBroadcast.OnMouseClick -= ChangeColor;
    }
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void ChangeColor(int position)
    {
        switch (position)
        {
            case 1:
                objectRenderer.material.color = Color.red;
                break;
            case 2:
                objectRenderer.material.color = Color.green;
                break;
            case 3:
                objectRenderer.material.color = Color.blue;
                break;
            case 4:
                objectRenderer.material.color = Color.yellow;
                break;
            default:
                break;
        }
    }
   
   
}
