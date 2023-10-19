using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    [SerializeField] private Transform _apple;
    private Rigidbody _rigidbody;
    public float gravityForce;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 gravity = (transform.position - _apple.position);
        transform.rotation = Quaternion.FromToRotation(transform.up, gravity) * transform.rotation;
        _rigidbody.AddForce(gravity * gravityForce * Time.deltaTime);
    }
}