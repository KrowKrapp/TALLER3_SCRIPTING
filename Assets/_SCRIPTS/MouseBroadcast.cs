using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseBroadcast : MonoBehaviour
{
   public static event Action<int> OnMouseClick;
    private int CurrentPosition =1;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            OnMouseClick?.Invoke(CurrentPosition);
            CurrentPosition++;
            if (CurrentPosition > 4)
            {
                CurrentPosition = 1;
            }
        }

    }
}
