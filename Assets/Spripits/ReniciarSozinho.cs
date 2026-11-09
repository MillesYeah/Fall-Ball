using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReniciarSozinho : MonoBehaviour
{
    public float tempoEspera = 10;

    void Update()
    {
        tempoEspera -= Time.unscaledDeltaTime;
        Debug.Log("tempoEspera: " + tempoEspera);
        if (tempoEspera <= 0)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Jogo normal mermo");
            
        }
    }
}
