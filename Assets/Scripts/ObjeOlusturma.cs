using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeOlusturma : MonoBehaviour
{
    public GameObject gameObject;
    void Start()
    {
        for(int i = -500; i < 500; i++)
        {
            GameObject go = Instantiate(gameObject);
            go.transform.position=new Vector3(Random.value * i, (Random.value * i) + 10, Random.value * i);
            go.transform.SetParent(transform);

        }
    }

    void Update()
    {
        
    }
}
