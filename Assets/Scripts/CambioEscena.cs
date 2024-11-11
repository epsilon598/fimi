using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEscena : MonoBehaviour
{
    [SerializeField] private GameObject Jugador, Terreno, Colegio, Canva, Placa1, CanvaInit, menu;
    [SerializeField] private GameObject[] objetosParaDesactivar; // Arreglo para almacenar los objetos a desactivar

    public void ActivarObj()
    {
        // Activa los objetos necesarios
        Jugador.SetActive(true);
        Terreno.SetActive(true);
        Colegio.SetActive(true);
        Canva.SetActive(true);
        Placa1.SetActive(true);
        CanvaInit.SetActive(false);

        // Desactiva todos los objetos en el arreglo
        foreach (GameObject obj in objetosParaDesactivar)
        {
            obj.SetActive(false);
        }
    }

    public void SalirJuego()
    {
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu != null)
            {
                menu.SetActive(!menu.activeSelf);
            }
        }
    }
}
