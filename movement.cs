using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float jumpHeight = 1.0f;
    public float moveDistance = 1.0f;
    public int moveLeftLimit = 3;
    public int moveRightLimit = 3;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 newPosition = transform.position + Vector3.up * jumpHeight;
            transform.position = newPosition;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 newPosition = transform.position - Vector3.up * jumpHeight;
            transform.position = newPosition;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && moveLeftLimit > 0)
        {
            moveLeftLimit--;
            moveRightLimit++;
            Vector3 newPosition = transform.position - Vector3.right * moveDistance;
            transform.position = newPosition;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && moveRightLimit > 0)
        {
            moveLeftLimit++;
            moveRightLimit--;
            Vector3 newPosition = transform.position + Vector3.right * moveDistance;
            transform.position = newPosition;
        }
    }

}
