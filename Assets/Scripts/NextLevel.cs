using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
     private Scene _scene;
     private void Awake()
    {
      _scene = SceneManager.GetActiveScene(); //cashing
    }

     private void OnTriggerEnter2D(Collider2D other) //bu fonkun çalışabilmesi için box collider 2d içinde "is trigger" açık olmalı.
    {
         if(other.gameObject.CompareTag("Player"))
      {
         SceneManager.LoadScene(_scene.buildIndex+1);
      }
    }

      public void StartLevel()
    {
       SceneManager.LoadScene(_scene.buildIndex+1);
    }
}
