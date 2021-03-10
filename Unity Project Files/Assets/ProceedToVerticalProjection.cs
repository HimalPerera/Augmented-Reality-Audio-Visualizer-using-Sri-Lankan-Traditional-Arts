using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProceedToVerticalProjection : MonoBehaviour
{
    public void GoBackToProjectionTypes(){
        SceneManager.LoadScene(1);
    }

   

    public void GoToVerticalScene(){
        SceneManager.LoadScene(7);
    }
}
