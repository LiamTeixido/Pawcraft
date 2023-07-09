using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2L2 : MonoBehaviour
{
    public GameObject targetObject1;
    public GameObject targetObject2;
    public GameObject targetObject3;
    public GameObject targetObject4;
    public GameObject targetObject5;
    public GameObject panelFinish;
    public GameObject check1;
    public GameObject check2;
    public GameObject check3;
    public GameObject check4;
    public GameObject check5;
    public int score;

    private void Start()
    {
        score = 0;
        LoadCollectibleProgress(); // Cargar el progreso de los objetos desbloqueados al inicio
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1f)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == targetObject1)
                {
                    IncreaseScore();
                    Destroy(targetObject1);
                    check1.SetActive(true);
                    SetCollectibleProgress(1, true); // Guardar el progreso del objeto desbloqueado
                }
                if (hit.collider.gameObject == targetObject2)
                {
                    IncreaseScore();
                    Destroy(targetObject2);
                    check2.SetActive(true);
                    SetCollectibleProgress(2, true); // Guardar el progreso del objeto desbloqueado
                }
                if (hit.collider.gameObject == targetObject3)
                {
                    IncreaseScore();
                    Destroy(targetObject3);
                    check3.SetActive(true);
                    SetCollectibleProgress(3, true); // Guardar el progreso del objeto desbloqueado
                }
                if (hit.collider.gameObject == targetObject4)
                {
                    IncreaseScore();
                    Destroy(targetObject4);
                    check4.SetActive(true);
                    SetCollectibleProgress(4, true); // Guardar el progreso del objeto desbloqueado
                }
                if (hit.collider.gameObject == targetObject5)
                {
                    IncreaseScore();
                    Destroy(targetObject5);
                    check5.SetActive(true);
                    SetCollectibleProgress(5, true); // Guardar el progreso del objeto desbloqueado
                }
            }
            if (score == 5)
            {
                panelFinish.SetActive(true);
                Time.timeScale = 0f;
                SaveCollectibleProgress(); // Guardar el progreso general de los objetos desbloqueados
            }
        }
    }

    private void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }

    private void SetCollectibleProgress(int collectibleIndex, bool unlocked)
    {
        PlayerPrefs.SetInt("Collectible_" + collectibleIndex, unlocked ? 1 : 0);
    }

    private void SaveCollectibleProgress()
    {
        PlayerPrefs.Save();
    }

    private void LoadCollectibleProgress()
    {
        for (int i = 1; i <= 5; i++)
        {
            bool unlocked = PlayerPrefs.GetInt("Collectible_" + i, 0) == 1;
            SetCollectibleStatus(i, unlocked);
        }
    }

    private void SetCollectibleStatus(int collectibleIndex, bool unlocked)
    {
        GameObject checkObject = null;

        switch (collectibleIndex)
        {
            case 1:
                checkObject = check1;
                break;
            case 2:
                checkObject = check2;
                break;
            case 3:
                checkObject = check3;
                break;
            case 4:
                checkObject = check4;
                break;
            case 5:
                checkObject = check5;
                break;
        }

        if (checkObject != null)
        {
            checkObject.SetActive(unlocked);
        }
    }
}
