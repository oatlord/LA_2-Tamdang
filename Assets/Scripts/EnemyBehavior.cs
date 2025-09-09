using UnityEngine;
using UnityEngine.Events;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int scoreValue;
    public GameObject scoreManager;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile"))
        {
            scoreManager.SendMessage("updateScore", scoreValue);
            Debug.Log("Score!");
            Destroy(gameObject);
        }
    }
}