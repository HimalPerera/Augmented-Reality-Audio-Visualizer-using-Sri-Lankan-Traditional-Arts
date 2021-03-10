using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ProjectionTypesMenuScript : MonoBehaviour
{
   public void GoToMainMenu(){
       SceneManager.LoadScene(0);
   }

    public void GoToMidAirGuidelines(){
       SceneManager.LoadScene(2);
   }
  
    public void GoToHorizontalGuidelines(){
       SceneManager.LoadScene(3);
   }

   public void GoToVerticalGuidelines(){
       SceneManager.LoadScene(4);
   }

   
}
