using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sahneler : MonoBehaviour
{
    
    void Start()
    {
    }

    void Update()
    {
        
    }
    //public void AnaMenu()
    //{
    //    SceneManager.LoadScene(0);


    //}
    //public void NasilOynanilir()
    //{
    //    SceneManager.LoadScene(1);
    //}
    public void OyunaBasla()
    {
        SceneManager.LoadScene(2);
        //PlayerPrefs.DeleteAll();
        //Time.timeScale = 0.0f;
    }
    public void Cikis()
    {
       
    }
    public void deneme()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
