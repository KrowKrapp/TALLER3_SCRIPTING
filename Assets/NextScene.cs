using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
    private int CurrentPosition = 2;
    Button button;

    private void Awake()
    {
        CurrentPosition = SceneManager.GetActiveScene().buildIndex;
    }
    public void GotoNextScene()
    {
        CurrentPosition++;
        if (CurrentPosition > SceneManager.sceneCountInBuildSettings - 1)
        {
            CurrentPosition = 0;
        }
        SceneManager.LoadScene(CurrentPosition);
    }
}
