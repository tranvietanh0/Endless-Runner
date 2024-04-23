using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float leftRightSpeed = 4f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * leftRightSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * leftRightSpeed * Time.deltaTime);
            }
        }
    }
}
