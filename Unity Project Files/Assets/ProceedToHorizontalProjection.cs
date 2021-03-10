using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProceedToHorizontalProjection : MonoBehaviour
{
    public void GoBackToProjectionTypes(){
        SceneManager.LoadScene(1);
    }

   

    public void GoToHorizontalScene(){
        SceneManager.LoadScene(6);
    }

  
}
