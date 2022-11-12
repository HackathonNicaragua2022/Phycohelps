using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarescena : MonoBehaviour
{
   public void LoadScene(string sceneName)
    {
        //este codigo me permite cambiar entre las pantallas de mi aplicacion, para que esto funcione
        //agrego este script a un objetovacio en UNITY y despues asigno ese objeto vacio a un evento click del boton
        //que es el responsable de realizar la accion.
        SceneManager.LoadScene(sceneName);
    }
}
