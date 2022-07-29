using TMPro;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float number = 1000;
    private Camera mainCamera;
    public Rigidbody2D _rigidbody;
    private Vector2 touchLastPos;
    public float speed;
    public bool Click;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Click = true;
            touchLastPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            speed = 0;
            Click = false;
        }
        else if (Input.GetMouseButton(0))
        {
            Click = true;
            Vector2 delta = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition) - touchLastPos;
            speed += delta.x * number;
            touchLastPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        }
    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(speed * 5, _rigidbody.velocity.y);
        speed = 0;
    }
}
