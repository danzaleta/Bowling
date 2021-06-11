using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour
{
    public Text puntaje;

    private int puntos = 0;
    private string puntosText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        puntos = puntos + 1;
        puntosText = puntos.ToString();
        puntaje.text = puntosText;
        Destroy(other.gameObject);
    }

}
