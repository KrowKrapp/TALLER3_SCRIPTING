using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseBroadCasterProjectile : MonoBehaviour
{
    public static event Action OnLeftClick;
    public static event Action<int> OnRightClick;
    private int CurrentPosition = 2;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !EventSystem.current.IsPointerOverGameObject())
        {
            OnRightClick?.Invoke(CurrentPosition);
            CurrentPosition++;
            if (CurrentPosition > 3)
            {
                CurrentPosition = 1;
            }
        }
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            OnLeftClick?.Invoke();
        }
    }
}
