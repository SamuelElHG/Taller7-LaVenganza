using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public float interactionRange;
    public GameObject popUp; // The object you want to display when the ray hits something
    public Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
        popUp.SetActive(false); // Initially, hide the popUp
    }

    private void Update()
    {
        // Perform a raycast from the position of the player in the forward direction.
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionRange))
        {
            if (hit.collider.CompareTag("Interactable") || hit.collider.CompareTag("DestroyableObs"))
            {
                popUp.SetActive(true);
            }
            else
            {
                popUp.SetActive(false);
            }
        }
        else
        {
            popUp.SetActive(false); // No hit detected, hide the popUp.
        }
    }
}
