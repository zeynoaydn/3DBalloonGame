using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SayacYazici : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text text2;
    void Start()
    {
        
    }
    void Update()
    {
        text.text ="Puan:"+ScoreSayaci.sayac.ToString();
        text2.text="Harcanan Mermi Sayýsý:"+ScoreSayaci.mermi.ToString();
    }
}
