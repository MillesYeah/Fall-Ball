using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReniciarSozinho : MonoBehaviour
{
    public float tempoEspera = 10;

    void update()
    {
        tempoEspera = Time.unscaledDeltaTime;
        if (tempoEspera <= 0)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(1);
        }
    }
}
