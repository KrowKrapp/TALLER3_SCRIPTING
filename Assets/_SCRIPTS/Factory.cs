using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject CreateCube(GameObject CreatePrefab, Vector3 position, Quaternion rotation)
    {
        GameObject prefab = Instantiate(CreatePrefab, position, rotation);
        return prefab;
    }

}
