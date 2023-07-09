using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleUI : MonoBehaviour
{
    public GameObject[] collectibleObjects;

    private void Start()
    {
        // Activar los objetos coleccionables según su estado de desbloqueo
        for (int i = 0; i < collectibleObjects.Length; i++)
        {
            collectibleObjects[i].SetActive(IsCollectibleUnlocked(i + 1));
        }
    }

    private bool IsCollectibleUnlocked(int collectibleIndex)
    {
        return PlayerPrefs.GetInt("Collectible_" + collectibleIndex, 0) == 1;
    }
}
