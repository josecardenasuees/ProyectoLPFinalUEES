using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoSonido : MonoBehaviour
{
    [SerializeField] private AudioClip SonidoPerdedor;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Persona"))
        {
            ControladorSonido.Instance.EjecutarSonido(SonidoPerdedor);
            Destroy(gameObject);
        }
    }
}
