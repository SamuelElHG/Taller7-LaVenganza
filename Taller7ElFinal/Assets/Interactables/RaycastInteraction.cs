using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteraction : MonoBehaviour
{
    public string targetTag = "MyTag"; // Tag of the GameObject you want to enable/disable
    public float interactionRange = 3f; // Range within which the player can interact
    private GameObject targetObject;

    private void Update()
    {
        // Find the target GameObject with the specified tag (move this to Start if it's not changing during gameplay)
        targetObject = GameObject.FindGameObjectWithTag(targetTag);

        // Check if the player presses the "F" key
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Check if the target GameObject is in range
            if (IsPlayerInRange(targetObject))
            {
                // Toggle the target GameObject's active state if it's not null
                if (targetObject != null)
                {
                    targetObject.SetActive(!targetObject.activeSelf);

                    // Log a message indicating successful interaction
                    Debug.Log("Player interacted with the object.");
                }
            }
        }
    }

    private bool IsPlayerInRange(GameObject target)
    {
        if (target == null)
        {
            return false;
        }

        // Calculate the distance between the player and the target object
        float distance = Vector3.Distance(transform.position, target.transform.position);

        // Check if the player is within the interaction range
        return distance <= interactionRange;
    }
}