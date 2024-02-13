using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play_Pause : MonoBehaviour
{
    public bool pause = false;
    public Sprite playSprite;
    public Sprite pauseSprite;
    public Button button;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Durdurma()
    {
        if (pause == false)
        {
            Time.timeScale = 0f;
            pause = true;
            button.image.sprite = playSprite;


        }
        else
        {
            Time.timeScale = 1f;
            pause = false;
            button.image.sprite = pauseSprite;
        }
    }
}
