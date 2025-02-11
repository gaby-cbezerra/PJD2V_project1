using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player; // Referência ao jogador; SerializeField é private, mas posso ver e mudar.
    [SerializeField] private float suavizacao = 0.125f; // Suavização do movimento
    [SerializeField] private Vector3 offset; // Distância entre a câmera e o jogador (transform da cam)

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 posicaoDesejada = player.position + offset;
        Vector3 posicaoSuavizada = Vector3.Lerp(transform.position, posicaoDesejada, suavizacao);
        transform.position = posicaoSuavizada;
    }
}
