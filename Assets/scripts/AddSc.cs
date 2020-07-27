using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSc : MonoBehaviour
{
    public int Puntaje = 20;

    void OnDestroy()
    {
        Score.Socoret += Puntaje;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
