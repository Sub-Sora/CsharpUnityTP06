using UnityEngine;

public class BirdDie : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("Get Hit");
            GameManager.Instance.GameOver();
        }
    }
}
