using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
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
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale ==1f)
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
                }
                if (hit.collider.gameObject == targetObject2)
                {
                    IncreaseScore();
                    Destroy(targetObject2);
                    check2.SetActive(true);
                }
                if (hit.collider.gameObject == targetObject3)
                {
                    IncreaseScore();
                    Destroy(targetObject3);
                    check3.SetActive(true);
                }
                if (hit.collider.gameObject == targetObject4)
                {
                    IncreaseScore();
                    Destroy(targetObject4);
                    check4.SetActive(true);
                }
                if (hit.collider.gameObject == targetObject5)
                {
                    IncreaseScore();
                    Destroy(targetObject5);
                    check5.SetActive(true);
                }
            }
            if(score==5)
            {
                panelFinish.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    private void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
