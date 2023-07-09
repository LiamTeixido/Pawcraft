using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockItems : MonoBehaviour
{
    GameManager gameManager;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;
    /*public GameObject item6;
    public GameObject item7;
    public GameObject item8;
    public GameObject item9;
    public GameObject item10;
    */
    public GameObject item1f;
    public GameObject item2f;
    public GameObject item3f;
    public GameObject item4f;
    public GameObject item5f;
    /*public GameObject item6f;
    public GameObject item7f;
    public GameObject item8f;
    public GameObject item9f;
    public GameObject item10f;
    */
    public void Unlockobjects()
    {
        if(gameManager.score==5)
        {
            item1.SetActive(true);
            item1f.SetActive(false);
            item2.SetActive(true);
            item2f.SetActive(false);
            item3.SetActive(true);
            item3f.SetActive(false);
            item4.SetActive(true);
            item4f.SetActive(false);
            item5.SetActive(true);
            item5f.SetActive(false);
        }
    }
}
