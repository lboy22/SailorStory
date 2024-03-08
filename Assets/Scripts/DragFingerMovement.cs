using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerMovement : MonoBehaviour
{
    [SerializeField] AudioSource spinachSound;

    private Vector3 touchPosition, direction;
    private Rigidbody2D rigidbody;
    private float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rigidbody.velocity = new Vector2(direction.x, direction.y) * movementSpeed;

            if(touch.phase == TouchPhase.Ended)
            {
                rigidbody.velocity = Vector2.zero;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spinachSound.Play();
        Destroy(collision.gameObject);
    }
}
