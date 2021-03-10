using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProceedToMidAirProjection : MonoBehaviour
{
    public void GoBackToProjectionTypes(){
        SceneManager.LoadScene(1);
    }

    public void GoToMidAirScene(){
        SceneManager.LoadScene(5);
    }


}
