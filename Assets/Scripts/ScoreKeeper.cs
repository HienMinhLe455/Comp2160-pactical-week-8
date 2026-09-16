using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Instance { get; private set; }

    public int CurrentScore { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void OnEnable()
    {
        //Coin.OnPickup += AddScore;
    }

    private void OnDisable()
    {
        //Coin.OnPickup -= AddScore;
    }

    public void AddScore(int points)
    {
        CurrentScore += points;
    }
}