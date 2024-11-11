using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEscena : MonoBehaviour
{

    [SerializeField] private GameObject Jugador,Terreno,Colegio,Canva,Placa1,CanvaInit,menu;
    public void ActivarObj()
    {
        Jugador.SetActive(true);
        Terreno.SetActive(true);
        Colegio.SetActive(true);
        Canva.SetActive(true);
        Placa1.SetActive(true);
        CanvaInit.SetActive(false);
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
