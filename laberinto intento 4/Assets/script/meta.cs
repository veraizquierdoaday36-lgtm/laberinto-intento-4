using System;
using UnityEngine;

public class meta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Jugador llego a la meta");
            pantallaFinal.SetActive(true);
        }
    }
}
