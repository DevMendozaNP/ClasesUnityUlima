using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallMovement : MonoBehaviour
{
    public float speedX = -4f;

    public float speedY = 0f;
    
    public float MinSpeedY = -4f;

    public float MaxSpeedY = 4f;

    public GameManagerPong GameManager;

    private void Start()
    {
        //Inscribir como Observador
        GameManager.OnPauseGame += Pause;
        GameManager.OnRestartGame += Restart;
    }

    private void Restart()
    {
        transform.position = new Vector3(
                0f,
                0f,
                0f
        );
        speedX = -4f;
    }
    private void Pause()
    {
        speedX = 0f;
        speedY = 0f;
    }

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
            if (other.transform.name == "ArcoIzquierda")
            {
                GameManager.Goal(1); //Gol de la derecha
            }else
            {
                GameManager.Goal(0); //Gol de la izquierda
            }
            transform.position = new Vector3(
                0f,
                0f,
                0f
            );
        }

    }    
}
