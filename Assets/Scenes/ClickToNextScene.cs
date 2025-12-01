using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickLoadSpecificScene : MonoBehaviour
{
    [SerializeField] private int sceneIndexToLoad = 1;   // <-- Aquí eliges el índice

    void Update()
    {
        if (Input.GetMouseButtonDown(0) ||
            (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            SceneManager.LoadScene(sceneIndexToLoad);
        }
    }
}