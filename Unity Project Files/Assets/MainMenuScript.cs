using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
   public void GoToProjectionTypeMenu(){
       SceneManager.LoadScene(1);
   }


    public void ExitApplication(){
        //Debug.Log("Exit!");
        Application.Quit();
    }

   
}
