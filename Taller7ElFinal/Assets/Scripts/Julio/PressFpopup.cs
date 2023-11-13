using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public float interactionRange;
    public GameObject popUp; // Press F popUp
    public GameObject cursorColorChange;
    public GameObject arrowpopUp;
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
                cursorColorChange.SetActive(true);
                arrowpopUp.SetActive(true);
            }
            else
            {
                popUp.SetActive(false);
                cursorColorChange.SetActive(false);
                arrowpopUp.SetActive(false);
            }
        }
        else
        {
            popUp.SetActive(false); // No hit detected, hide the popUp.
            cursorColorChange.SetActive(false);
            arrowpopUp.SetActive(false);
        }
    }
}
