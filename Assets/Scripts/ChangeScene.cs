using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //Cambio de escena
    public void ChangerScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
