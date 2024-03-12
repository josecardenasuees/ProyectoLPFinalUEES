using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrilComponent : MonoBehaviour
{
    public GameManager myGameManager;
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("ZombieMale"))
		{
			ObjectDeath();
		}
		else if (collision.CompareTag("ZombieFemale"))
		{
			//Destroy(collision.gameObject);
			ObjectDeath();
		}
	}

	void ObjectDeath()
	{
		Destroy(gameObject);
	}    
}
