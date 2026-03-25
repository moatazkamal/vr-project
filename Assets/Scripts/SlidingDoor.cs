using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    [Header("Door Settings")]
    [SerializeField] private float slideAmount = 2f;
    [SerializeField] private float slideSpeed = 2f;

    [Header("Slide Direction")]
    [SerializeField] private Vector3 slideDirection = Vector3.right;

    private Vector3 closedPosition;
    private Vector3 openPosition;
    private bool shouldOpen = false;

    private void Start()
    {
        closedPosition = transform.position;
        openPosition = closedPosition + slideDirection.normalized * slideAmount;
    }

    private void Update()
    {
        if (shouldOpen)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                openPosition,
                slideSpeed * Time.deltaTime
            );
        }
    }

    public void OpenDoor()
    {
        shouldOpen = true;
    }
}