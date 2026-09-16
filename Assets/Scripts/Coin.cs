using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            ScoreKeeper.Instance.AddScore(points);
            Destroy(gameObject);
        }
    }
}
