using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GameManagerPong : MonoBehaviour
{
    public int puntuacionJugadorIzq = 0;
    public int puntuacionJugadorDer = 0;


    public TextMeshProUGUI textPuntajeIzq;

    public TextMeshProUGUI textPuntajeDer;

    public event UnityAction OnPauseGame; //evento

    public event UnityAction OnRestartGame; //reiniciar

    // jugador = 0 -> Jugador Izquierda
    // jugador = 0 -> Jugador Derecha 
    public void Goal(int jugador)
    {
        if (jugador == 0)
        {
            puntuacionJugadorIzq = puntuacionJugadorIzq + 1;
            textPuntajeIzq.text = puntuacionJugadorIzq.ToString();
        }else
        {
            puntuacionJugadorDer++;
            textPuntajeDer.text = puntuacionJugadorDer.ToString();
        }
        textPuntajeIzq.gameObject.SetActive(true);
        textPuntajeDer.gameObject.SetActive(true);
        OnPauseGame.Invoke();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //reiniciar el juego
            textPuntajeIzq.gameObject.SetActive(false);
            textPuntajeDer.gameObject.SetActive(false);
            OnRestartGame.Invoke();
        }
    }
}
