using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class XRGrabInteractableFixed : XRGrabInteractable
{
    [SerializeField] private Transform leftHandAttachTransform;
    [SerializeField] private Transform rightHandAttachTransform;

    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        base.OnSelectEntering(args);

        // Get which hand is grabbing
        if (args.interactorObject.handedness == InteractorHandedness.Left)
        {
            if (leftHandAttachTransform != null)
            {
                attachTransform.position = leftHandAttachTransform.position;
                attachTransform.rotation = leftHandAttachTransform.rotation;
            }
        }
        else if (args.interactorObject.handedness == InteractorHandedness.Right)
        {
            if (rightHandAttachTransform != null)
            {
                attachTransform.position = rightHandAttachTransform.position;
                attachTransform.rotation = rightHandAttachTransform.rotation;
            }
        }
    }
}