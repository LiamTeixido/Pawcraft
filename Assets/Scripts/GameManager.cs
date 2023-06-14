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
    public GameObject panelFinish;
    public int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == targetObject1)
                {
                    IncreaseScore();
                    Destroy(targetObject1);
                }
                if (hit.collider.gameObject == targetObject2)
                {
                    IncreaseScore();
                    Destroy(targetObject2);
                }
                if (hit.collider.gameObject == targetObject3)
                {
                    IncreaseScore();
                    Destroy(targetObject3);
                }
            }
            if(score==3)
            {
                panelFinish.SetActive(true);
            }
        }
    }

    private void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
