using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSensor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bola Passou! Total perdidas" + GameManager.Instance.droppedBalls);
        if (other.gameObject.tag == "ball")
        {
            GameManager.Instance.balls_dropped();
            
            Destroy(other.gameObject);
        }
    }
}