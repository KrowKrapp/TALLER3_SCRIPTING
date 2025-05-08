using UnityEngine;

public class Logger : MonoBehaviour
{
    private void OnEnable()
    {
        MouseBroadcast.OnMouseClick += Log;
    }

    private void OnDisable()
    {
        MouseBroadcast.OnMouseClick -= Log;
    }
    void Log(int position)
    {
        print("Mouse clicked at rotation position: " + position);
    }

}
