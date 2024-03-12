using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageControllerDeath : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("arbol"))
        {
            Destroy(collision.gameObject);
        }
    }
}
