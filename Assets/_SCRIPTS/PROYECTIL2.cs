using System;
using UnityEngine;

public class PROYECTIL2 : MonoBehaviour
{
    public static event Action<bool> OnProjectileCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Proyectil"))
        {
            return;
        }

        collision.collider.enabled = false;
        OnProjectileCollision?.Invoke(false);

        CubeController cubeController = collision.gameObject.GetComponent<CubeController>();
        if (cubeController != null)
        {
            cubeController.EnableColliderAfterDelay(1f); 
        }

        this.gameObject.SetActive(false);
    }
}
