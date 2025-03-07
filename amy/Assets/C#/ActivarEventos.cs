using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivarEventos : MonoBehaviour
{
    //lista de los tags
    [SerializeField] List<string> Tags = new List<string>();

    //Eventos creados
    [SerializeField] UnityEvent eventosAlEntrar;
    [SerializeField] UnityEvent eventosAlSalir;

    private void OnTriggerEnter(Collider other)
    {
        if (Tags.Contains(other.tag))
        {
            eventosAlEntrar?.Invoke();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(Tags.Contains(other.tag))
        {
            eventosAlSalir?.Invoke();
        }
        
    }
}
