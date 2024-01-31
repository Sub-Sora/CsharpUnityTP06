using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float _PipeSpeed = 2f;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = new Vector2(-_PipeSpeed, 0f);
    }
}
