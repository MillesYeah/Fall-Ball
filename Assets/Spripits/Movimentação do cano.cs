using UnityEngine;
public class MovimentaçãoDoCano : MonoBehaviour
{
    public float velocidade = 5f;
    public float limiteX= 42f;
    public float limiteX2 = 42f;
    void Update()
    {
        bool isPressingLeft = Input.GetKey(KeyCode.A);
        bool isPressingRight = Input.GetKey(KeyCode.D);
        float moviment = velocidade * Time.deltaTime;
        if (isPressingLeft == isPressingRight)
        {
            return;
        }
        if (isPressingLeft)
        {
            moviment *= -1;
        }
        transform.position += new Vector3(moviment, 0f, 0f);
        float clampedX = Mathf.Clamp(transform.position.x, -limiteX2, limiteX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}