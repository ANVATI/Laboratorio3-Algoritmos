using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public float speed = 2.0f;
    public float minX, maxX, minY, maxY;
    public bool moveInX = true;

    private int direction = 1;

    void Update()
    {
        if (moveInX)
        {
            // Mover al enemigo en el eje X
            transform.position = new Vector2(transform.position.x + direction * speed * Time.deltaTime, transform.position.y);

            // Cambiar la dirección si el enemigo alcanza los límites en el eje X
            if (transform.position.x >= maxX)
            {
                direction = -1;
            }
            else if (transform.position.x <= minX)
            {
                direction = 1;
            }
        }
        else
        {
            // Mover al enemigo en el eje Y
            transform.position = new Vector2(transform.position.x, transform.position.y + direction * speed * Time.deltaTime);

            // Cambiar la dirección si el enemigo alcanza los límites en el eje Y
            if (transform.position.y >= maxY)
            {
                direction = -1;
            }
            else if (transform.position.y <= minY)
            {
                direction = 1;
            }
        }
    }
}
