using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDetccionPiso : MonoBehaviour
{
    [SerializeField] LayerMask capaDeteccion;
    [SerializeField] Transform objetivo;

    // Update is called once per frame
    void Update()
    {
        //Rectifica que el boton izquierdo del mouse ha sido precionado
 
        if (Input.GetMouseButtonDown(0))
        {
            //GENERA UN RAYO DESDE LA POSICION DEL MOUSE EN LA PANTAKLLA, TENIENDO EN CUENTA LA CAMRA MAIN QUE ESTA RENDERIZANDO
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);

            //CREAMOS UNA VARIABLE QUE RECIBA LA INFORMACION DE LA COLISION DEL RAYO
            RaycastHit hit;

            //LANZAMOS EL RAYO QUE RETORNA UN VALOR VERDADERO SI HUBO COLISION Y UN VALOR FALSO SI NO HUBO COLISION
            if (Physics.Raycast(rayo, out hit, Mathf.Infinity, capaDeteccion))
            {
                //MOVEMOS UN OBJETO A LA POSICION DONDE HUBO COLISION
                objetivo.transform.position = hit.point;
            }
        }
            
        

    }
}
