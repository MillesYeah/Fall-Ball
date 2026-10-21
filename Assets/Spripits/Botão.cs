using UnityEngine;
using UnityEngine.SceneManagement;

public class Botão : MonoBehaviour
{
    public void Reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Jogo normal mermo");
    }
}