using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    [Header("Player Reference")]
    [SerializeField] private Transform player;

    [Header("Door Settings")]
    [SerializeField] private float openDistance = 2f;
    [SerializeField] private float slideAmount = 2f;
    [SerializeField] private float slideSpeed = 2f;

    [Header("Slide Direction")]
    [SerializeField] private Vector3 slideDirection = Vector3.right;

    private Vector3 closedPosition;
    private Vector3 openPosition;
    private bool shouldOpen = false;
    private bool hasOpened = false;

    private void Start()
    {
        closedPosition = transform.position;
        openPosition = closedPosition + slideDirection.normalized * slideAmount;
    }

    private void Update()
    {
        if (player == null)
        {
            return;
        }

        if (!hasOpened)
        {
            float distance = Vector3.Distance(player.position, transform.position);

            if (distance <= openDistance)
            {
                shouldOpen = true;
                hasOpened = true;
            }
        }

        if (shouldOpen)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                openPosition,
                slideSpeed * Time.deltaTime
            );
        }
    }
}