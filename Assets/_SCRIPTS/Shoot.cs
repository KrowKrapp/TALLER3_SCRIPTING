using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Vector3 firePoint;
    private bool canShoot = true;

    private void OnEnable()
    {
        MouseBroadCasterProjectile.OnLeftClick += Fire;
        CubeController.CantShoot += HandleProjectileCollision;
    }

    private void HandleProjectileCollision(bool obj)
    {
        canShoot = obj;  
    }

    private void Fire()
    {
        if (!canShoot)
        {
            return;  
        }

        GameObject projectile = ProjectileChanger.SelectedPool.GetPooledObject();

        if (projectile != null)
        {
            projectile.transform.position = firePoint;
            projectile.transform.rotation = Quaternion.identity;
            projectile.SetActive(true);
        }
    }

    private void OnDisable()
    {
        MouseBroadCasterProjectile.OnLeftClick -= Fire;
        CubeController.CantShoot -= HandleProjectileCollision;
    }
}
