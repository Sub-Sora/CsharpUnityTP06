using UnityEngine;

public class BirdScored : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.AddScore();
    }
}
