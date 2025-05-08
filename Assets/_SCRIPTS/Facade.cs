using UnityEngine;

public class Facade : MonoBehaviour
{
    Factory factory = new Factory();
    public GameObject Create(GameObject prefab, Vector3 position, Quaternion rotation)

    {
        if (prefab == null)
        {
            Debug.LogError("Prefab is null");
            return null;
        }
        return factory.CreateCube(prefab, position, rotation);
    }

}
