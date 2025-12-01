using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Evita que se destruya al cambiar de escena
        }
        else
        {
            Destroy(gameObject); // Evita duplicados si la escena vuelve a crear otro
        }
    }
}