using UnityEngine;
using Oculus.Interaction;
using Oculus.Interaction.Input;

public class DisableGrabbingModel : MonoBehaviour
{
    [Header("Hand Models")]
    public GameObject leftHandModel;
    public GameObject rightHandModel;

    [Header("Hand Grab")]
    //public HandGrabInteractable handGrabInteractable;

    private bool wasSelected = false;

    /*private void Awake()
    {
        if (handGrabInteractable == null)
        {
            handGrabInteractable = GetComponent<HandGrabInteractable>();
        }
    }

    private void Update()
    {
        if (handGrabInteractable == null)
            return;

        bool isSelected = handGrabInteractable.State == InteractableState.Select;

        if (isSelected && !wasSelected)
        {
            OnGrab();
        }
        else if (!isSelected && wasSelected)
        {
            OnRelease();
        }

        wasSelected = isSelected;
    }

    private void OnGrab()
    {
        // Aquí sabemos que el objeto está siendo agarrado,
        // pero no qué mano lo está agarrando.

        if (leftHandModel != null)
            leftHandModel.SetActive(false);

        if (rightHandModel != null)
            rightHandModel.SetActive(false);
    }

    private void OnRelease()
    {
        if (leftHandModel != null)
            leftHandModel.SetActive(true);

        if (rightHandModel != null)
            rightHandModel.SetActive(true);
    }*/
}