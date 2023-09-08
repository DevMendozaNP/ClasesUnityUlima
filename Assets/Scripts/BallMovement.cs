using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speedX = -4f;

    public float speedY = 0f;
    
    public float MinSpeedY = -4f;

    public float MaxSpeedY = 4f;

    private void Update()
    {
        Vector3 newPos = new Vector3(
            transform.position.x + (speedX * Time.deltaTime),
            transform.position.y + (speedY * Time.deltaTime),
            0f
        );
        transform.position = newPos;
        //transform.position se usa cuando queremos cambiar la ubicación del objeto en el que pones el script
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Paleta"))
        {
            speedX = speedX * -1;
            speedY = UnityEngine.Random.Range(MinSpeedY, MaxSpeedY);
        }else if (other.transform.CompareTag("Pared"))
        {
            speedY = speedY * -1;
        }else if (other.transform.CompareTag("Arcos"))
        {
            transform.position = new Vector3(
                0f,
                0f,
                0f
            );
        }

    }    
}
