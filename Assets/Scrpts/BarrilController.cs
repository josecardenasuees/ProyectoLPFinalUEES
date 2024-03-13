using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilController : MonoBehaviour
{
    private Rigidbody2D myrigidbody2D;
    public float barrilSpeed = 10f;
    public GameManager myGameManager;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        myGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody2D.velocity = new Vector2(barrilSpeed, myrigidbody2D.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ZombieMale") || collision.CompareTag("ZombieFemale"))
        {
            // Si tiene una de las etiquetas deseadas, destruir el objeto colisionado
            Destroy(collision.gameObject);
            //Destroy(this.gameObject);
            //Destroy(gameObject);
        }
    }
}
