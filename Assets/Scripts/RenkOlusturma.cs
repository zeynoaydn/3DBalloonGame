using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Renk
{
    Mavi,
    Yesil,
    Turuncu,
    Kirmizi,
    Sari
}
public class RenkOlusturma : MonoBehaviour
{
    public Renk _renk;
    void Start()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        Material mat = mr.material;

        _renk = SecilenRenk();
        mat.color = RenkToColor(_renk);

    }

    Renk SecilenRenk()
    {
        return (Renk)Random.Range(0,System.Enum.GetValues(typeof(Renk)).Length);
    }

    public Color RenkToColor(Renk renk)
    {
        switch (renk)
        {
            case Renk.Mavi:
                return Color.blue;
            case Renk.Yesil:
                return Color.green;
            case Renk.Turuncu:
                return Color.cyan;
            case Renk.Kirmizi:
                return Color.red;
            case Renk.Sari:
                return Color.yellow;
            default:
                return Color.white;
        }
    }

    void Update()
    {
        
    }
}
