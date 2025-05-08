using System;
using System.Collections;
using UnityEngine;

public class CubeController : MonoBehaviour
{    
    public static event Action<bool> CantShoot;
    public void EnableColliderAfterDelay(float delay)
    {
        CantShoot?.Invoke(false);
        StartCoroutine(EnableColliderCoroutine(delay));
    }

    private IEnumerator EnableColliderCoroutine(float delay)
    {
        yield return new WaitForSeconds(delay);

        Collider collider = GetComponent<Collider>();
        collider.enabled = true;
        CantShoot?.Invoke(true);
    }
}
