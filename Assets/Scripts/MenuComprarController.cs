using UnityEngine;
using UnityEngine.UI;

public class MenuComprarController : MonoBehaviour
{
    public GameObject menuComprar; // Asigna el objeto MenuComprar en el Inspector
    public GameObject placa;
    [SerializeField] private GameObject[] objetosParaDesactivar;
    public Button aceptarButton;   // Asigna el botón Aceptar desde el Inspector
    public Button cancelarButton;  // Asigna el botón Cancelar desde el Inspector
    public GameManager gameManager;
    [SerializeField] public int precio;
     public GameObject placaActivar;

    private void Start()
    {
        if (gameManager == null)
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }

        aceptarButton.onClick.AddListener(OnAceptarClick);
        cancelarButton.onClick.AddListener(OnCancelarClick);
    }

    private void OnAceptarClick()
    {
        Debug.Log("Botón Aceptar presionado.");
    
        // Verifica si el presupuesto es suficiente
        if (gameManager.budget >= precio)
        {
            gameManager.SubtractMoney(precio);
            Debug.Log($"{precio} monedas restadas.");
    
            // Oculta el menú de compra y la placa, y activa los objetos necesarios
            menuComprar.SetActive(false);
            placa.SetActive(false);
            
            foreach (GameObject obj in objetosParaDesactivar)
            {
                obj.SetActive(true);
            }
            
            placaActivar.SetActive(true);
            
            Debug.Log("MenuComprar ocultado y objetos activados.");
        }
        else
        {
            Debug.Log("No tienes suficiente presupuesto.");
        }
    }


    private void OnCancelarClick()
    {
        Debug.Log("Botón Cancelar presionado.");
        
        // Oculta el menú sin hacer cambios
        menuComprar.SetActive(false);
        Debug.Log("MenuComprar ocultado por el botón Cancelar.");
    }
}
