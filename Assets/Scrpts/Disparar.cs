using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;
    [SerializeField] private float tiempoEntreDisparos;
    private float tiempoSiguienteDisparo;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time > tiempoSiguienteDisparo)
		{
			DispararBala();
			tiempoSiguienteDisparo = Time.time + tiempoEntreDisparos;
		}
    }
	private void DispararBala()
	{
		Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
	}    
}
