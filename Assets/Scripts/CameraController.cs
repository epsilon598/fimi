using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;            // Referencia al jugador
    public float height = 15f;          // Altura de la cámara sobre el jugador
    public float distance = 0f;         // Distancia horizontal desde el jugador (opcional)
    public float smoothSpeed = 0.125f;  // Velocidad de suavizado de la cámara

    void Start()
    {
        // Si no has asignado al jugador manualmente en el inspector, búscalo por el tag "Player"
        if (player == null)
        {
            player = GameObject.FindWithTag("Player").transform;
        }
    }

    void LateUpdate()
    {
        // Calcula la posición deseada directamente encima del jugador, con altura y distancia ajustables
        Vector3 desiredPosition = new Vector3(player.position.x + distance, player.position.y + height, player.position.z);

        // Interpola suavemente entre la posición actual y la deseada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Asigna la nueva posición suavizada a la cámara
        transform.position = smoothedPosition;

        // Apunta la cámara directamente hacia abajo
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
