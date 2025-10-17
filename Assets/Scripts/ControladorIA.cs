using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using static ControladorIA;

public class ControladorIA : MonoBehaviour
{
    public enum Estados
    {
        Esperar,
        Patrulhar,
        Perseguir,
        Procurar
    }

    public Estados estadoAtual;

    public AICharacterControl aICharacterControl;
    private Transform alvo;

    private void Awake()
    {
        aICharacterControl = GetComponent<AICharacterControl>();
    }

    private void ChecarEstados()
    {
        switch (estadoAtual)
        {
            case Estados.Esperar:
                if (EsperouTempoSuficiente())
                {

                }
                else
                {
                    alvo = transform;
                }
                break;
            case Estados.Patrulhar:
                break;
            case Estados.Perseguir:
                break;
            case Estados.Procurar:
                break;
            default:
                break;
        }
        aICharacterControl.target = alvo;

    }
    [Header("Estado: Esperar")]
    public float tempoEsperar = 2f;
    private float tempoEsperando;

    private bool EsperouTempoSuficiente()
    {
        return tempoEsperando + tempoEsperar <= Time.time;
    }

}
