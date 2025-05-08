using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button Cubo, Esfera, Torus, Instanciar;
    public GameObject prefabCubo, prefabEsfera, prefabTorus;
    private GameObject prefabSeleccionado;
    private Facade facade = new Facade();

 
    void Start()
    {
        prefabSeleccionado = prefabCubo;
        Cubo.onClick.AddListener(() => prefabSeleccionado = prefabCubo);
        Esfera.onClick.AddListener(() => prefabSeleccionado = prefabEsfera);
        Torus.onClick.AddListener(() => prefabSeleccionado = prefabTorus);
        Instanciar.onClick.AddListener(InstanciarObjeto);


    }

    void InstanciarObjeto()
    {
        GameObject objeto = facade.Create(prefabSeleccionado, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)), Quaternion.identity);

    }
}
