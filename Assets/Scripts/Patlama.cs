using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patlama : MonoBehaviour
{

    RenkOlusturma renkverici;
   
    void Start()
    {
        ScoreSayaci scoreSayaci=GetComponent<ScoreSayaci>();
        renkverici = GetComponent<RenkOlusturma>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        string ad = collision.gameObject.name;
        Renk benimsecilenrengim = renkverici._renk;

        if (ad.Contains("Mermi(Clone)"))
        {
            //ScoreSayacý.sayac++;
            if (benimsecilenrengim == Renk.Mavi)
            {
                ScoreSayaci.sayac++;
            }
            else if (benimsecilenrengim == Renk.Yesil)
            {
                ScoreSayaci.sayac += 2;
            }
            else if (benimsecilenrengim == Renk.Sari)
            {
                ScoreSayaci.sayac += 3;
            }
            else if (benimsecilenrengim == Renk.Kirmizi)
            {
                ScoreSayaci.sayac += 4;
            }
            else if (benimsecilenrengim == Renk.Turuncu)
            {
                ScoreSayaci.sayac += 5;
            }

            Destroy(gameObject);
        }
        //if (collision.gameObject.name == "Mermi(Clone)")
        //{
        //    ScoreSayaci.sayac++;
        //    Destroy(gameObject);
        //}
    }
    void Update()
    {
    }
}
