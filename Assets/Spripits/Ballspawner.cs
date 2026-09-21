using UnityEngine;

public class Ballspawner : MonoBehaviour
{
    public GameObject[] Bolas;
    public float Intervalo = 2f;
    public float Largura = 10f;
    void Start()
    {
       InvokeRepeating(nameof(SpawnBall), 0f, Intervalo);
    }
    void SpawnBall()
    {
        int indice = Random.Range(0, Bolas.Length);
        float X=Random.Range(-Largura / 2f, Largura / 2f);
        Vector3 posicao = transform.position + new Vector3(X, 0, 0);
        Instantiate(Bolas[indice], posicao, Quaternion.identity);
    }
}
