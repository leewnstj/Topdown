using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float playerSpeed;
    [SerializeField] Camera cam;
    [SerializeField] Rigidbody2D rigid;

    Vector2 movement;
    Vector2 mousePoint;

    private void Update()
    {
        PlayerMove();
    }

    private void FixedUpdate()
    {
        PlayerRotation();
    }

    private void PlayerMove()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePoint = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void PlayerRotation()
    {
        rigid.velocity = new Vector2(movement.x, movement.y).normalized * playerSpeed;

        Vector2 lookDir = mousePoint - rigid.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rigid.rotation = angle;
    }
}
