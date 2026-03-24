using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToEnable;

    public void StartGame()
    {
        foreach (GameObject obj in objectsToEnable)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}