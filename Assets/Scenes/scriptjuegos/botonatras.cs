using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class botonatras : MonoBehaviour
{
    //este codigo me permite darle la accion a un elemento llamado boton,
    //para realizar la accion de regresar a la pantalla anterior.
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
