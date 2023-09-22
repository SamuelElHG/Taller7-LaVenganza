using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteraction : MonoBehaviour
{
    // Define a reference to the GameObject or component you want to toggle.
    public GameObject interactableObject;

    // Define the maximum interaction distance.
    public float interactionRange = 2.0f;

    private void Update()
    {
        // Check for the "F" key press.
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Calculate the distance between the player and the interactable object.
            float distance = Vector3.Distance(transform.position, interactableObject.transform.position);

            // Check if the player is within the interaction range.
            if (distance <= interactionRange)
            {
                // Toggle the interactable state.
                ToggleInteractableObject();
            }
        }
    }

    // Function to toggle the interactable object on or off.
    private void ToggleInteractableObject()
    {
        if (interactableObject != null)
        {
            // Toggle the GameObject or component's active state.
            interactableObject.SetActive(!interactableObject.activeSelf);
        }
    }
}








