using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//esta es una clase que me permite darle un valor a mi boton 
public class enlacearedes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // este codigo me permite asigarle a un boton la habilidad de sacarme de la aplicacion
    //para entrar a las redes sociales oficiales de mi aplicacion.
    public void EnlaceARedes (string enlace)
    {
        Application.OpenURL(enlace);
    }
}
