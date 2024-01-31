using UnityEngine;

public class BirdJump : MonoBehaviour
{

    [SerializeField] private float _ImpulseJump;
    private Rigidbody2D _rb;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _ImpulseJump);

            if (_animator != null)
            {
                _animator.Rebind();
            }
        }
    }
}
