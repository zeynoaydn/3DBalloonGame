using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    public GameObject mermi;
    Rigidbody rigid;
    public Transform cameraTransform;
    void Start()
    {
        ScoreSayaci scoreSayaci=GetComponent<ScoreSayaci>();
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0) /*Input.GetKeyDown(KeyCode.Space)*/) 
        {
            Vector3 pos = cameraTransform.position;
            Vector3 dir = cameraTransform.forward;

            GameObject go = Instantiate(mermi, pos, Quaternion.identity);
            Rigidbody rigid = go.GetComponent<Rigidbody>();
            rigid.AddForce(dir * 5000.0f, ForceMode.Force);
            go.transform.SetParent(transform);
            ScoreSayaci.mermi++;
        }
    }
}
