using UnityEngine;

public class Easing : MonoBehaviour
{
  public Vector3 sentidoMovimento = Vector3.left;
  public float velocidade = 2f;
  public float delayDirecao = 2f;
  private int direcao = 1;

  void Awake()
  {
    InvokeRepeating("InverterDirecao", delayDirecao, delayDirecao);
  }

  void Update()
  {
    transform.Translate(
      sentidoMovimento * direcao * velocidade * Time.deltaTime,
      Space.World
    );
  }

  void InverterDirecao()
  {
    direcao *= -1;
  }
}