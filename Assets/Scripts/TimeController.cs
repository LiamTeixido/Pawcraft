using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public float startTime;
    private float currentTime;

    public Image timerImage;
    public GameObject panelFinish;

    private void Start()
    {
        currentTime = startTime;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        // Calcula el fill amount basado en el tiempo actual y el tiempo inicial.
        float fillAmount = currentTime / startTime;

        // Actualiza el fill amount de la imagen del temporizador.
        timerImage.fillAmount = fillAmount;

        if (currentTime <= 0)
        {
            panelFinish.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
