using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScriptVerticalScene : MonoBehaviour
{

    public void GoToProjectionTypeMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
