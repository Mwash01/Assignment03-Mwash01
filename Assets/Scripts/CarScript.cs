using UnityEngine;

public class CarScript : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start() {
        Destroy(gameObject, 4);
    }

    void FixedUpdate() {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * Data.carSpeed);

    }

}
