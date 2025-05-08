using UnityEngine;

public class ProjectileChanger : MonoBehaviour
{
    public PoolParent pool1;
    public PoolParent pool2;
    public PoolParent pool3;

    public static PoolParent SelectedPool { get; private set; }

    private void OnEnable()
    {
        MouseBroadCasterProjectile.OnRightClick += ChangeProjectile;
        SelectedPool = pool1;
    }

    private void OnDisable()
    {
        MouseBroadCasterProjectile.OnRightClick -= ChangeProjectile;
    }

    void ChangeProjectile(int position)
    {
        switch (position)
        {
            case 1:
                SelectedPool = pool1;
                break;
            case 2:
                SelectedPool = pool2;
                break;
            case 3:
                SelectedPool = pool3;
                break;
            default:
                SelectedPool = pool1;
                break;
        }

        Debug.Log($"Projectile changed to: {SelectedPool.name}");
    }
}
