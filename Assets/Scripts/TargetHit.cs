using UnityEngine;

public class TargetHit : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;

    public void RegisterHit()
    {
        if (scoreManager != null)
        {
            scoreManager.AddScore();
        }
    }
}