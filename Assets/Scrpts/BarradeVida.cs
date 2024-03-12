using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarradeVida : MonoBehaviour
{
    /*
    public Image barraVida;
    public float vidaActual;
    public float vidaMaxima;

    // Update is called once per frame
    void Update()
    {
        barraVida.fillAmount = vidaActual / vidaMaxima;
    }
    */
    private Slider slider;
    
    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void CambiarVidaMaxima(float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }
    public void CambiarVidaActual(float cantidadVida)
    {
        slider.maxValue = cantidadVida;
    }

    public void InicializarBarradeVida(float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }
}
