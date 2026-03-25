using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private SlidingDoor linkedDoor;
    [SerializeField] private int requiredScoreToOpen = 5;

    private int score = 0;
    private bool doorOpened = false;

    private void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int amount = 1)
    {
        score += amount;
        UpdateScoreUI();

        if (!doorOpened && linkedDoor != null && score >= requiredScoreToOpen)
        {
            linkedDoor.OpenDoor();
            doorOpened = true;
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }
}