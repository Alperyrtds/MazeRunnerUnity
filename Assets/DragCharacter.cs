using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCharacter : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    private Rigidbody2D rb;

    void Start()
    {
        // Rigidbody2D bileþenini al
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPos();
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void FixedUpdate()
    {
        if (isDragging)
        {
            Vector3 newPosition = GetMouseWorldPos() + offset;

            // MovePosition kullanarak hareket et
            rb.MovePosition(newPosition);
        }
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = 0f;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Çarpýþma Algýlandý: " + collision.gameObject.name);
    }
}



