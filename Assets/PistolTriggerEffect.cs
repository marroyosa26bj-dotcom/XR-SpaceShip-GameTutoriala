
using UnityEngine;
using Oculus.Interaction;

public class PistolTriggerEffect : MonoBehaviour
{
    [Header("GameObject que se activa al apretar el gatillo")]
    [SerializeField] private GameObject objetoActivar;

    [Header("Umbral de pulsación del gatillo")]
    [SerializeField, Range(0f, 1f)]
    private float umbral = 0.5f;

    [Header("Si esta agarrado el objeto")]
    [SerializeField] GrabInteractable grabInteractable;

    bool triggerPulled = false;

    public LayerMask layerMask; // Capa que quieres ignorar
    public Transform shootSource; // Objeto de referencia para la dirección del rayo
    public float distance = 10f; // Distancia máxima del rayo

    private void Start()
    {
        // Empieza con el objeto desactivado
        if (objetoActivar != null)
        {
            objetoActivar.SetActive(false);
        }
        else
        {
            Debug.LogWarning(
                "Asigna un GameObject en el Inspector.",
                this
            );
        }
    }

    private void Update()
    {
        if (objetoActivar == null || grabInteractable == null)
            return;

        // Si la pistola no está seleccionada, desactivar el efecto
        if (grabInteractable.State != InteractableState.Select)
        {
            objetoActivar.SetActive(false);
            return;
        }
            
        // Solo llega aquí si la pistola está agarrada
        bool gatilloIzquierdo = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) > umbral;

        bool gatilloDerecho = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) > umbral;

        bool gatilloPulsado = gatilloIzquierdo || gatilloDerecho;

        // Mantener el efecto mientras se pulse el gatillo
        if (objetoActivar.activeSelf != gatilloPulsado)
        {
            objetoActivar.SetActive(gatilloPulsado);
        }

    }

    void RayCastCheck()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(shootSource.position, shootSource.forward, out hit, distance, layerMask);
    }


}
