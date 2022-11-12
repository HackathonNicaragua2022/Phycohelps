using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlarvolumen : MonoBehaviour
{
    // estas clases me permiten declarar elemtos de mi juego en el codigo y darles acciones propias, 
    // el slider es un elemto que me permite cambiar los valores que yo quiera en el juego por ejemplo bajar y subir el volumen




    public Slider slider;
    public float sliderValue;
    public Image imageMute;
    // Start is called before the first frame update
    void Start()
    {
       //con este codigo le doy una orden a mi elemento de iniciar en determinada posicion cuando se ejecute
       // revisarsiestoy mute es una imagen que esta condicionada a aparecer si el audiop esta en MUTE
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();

    }
    public void ChangeSlider(float valor)
    {
        //esta parte del codigo se encarga de evaluar la posicion que le da el usuario al slider, dependiendo de la posicion que sea
        //la musica sube o baja


        // se vuelve a hacer una referencia a la imagen condicionada a aperecer si el audio esta MUTE
        slider.value = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }

    // se hace una clase publica para darle existencia a la referencia REVISARSIESTOYMUTE
    // esta es la condicion a la que esta sujeta la imagen MUTE


     public void RevisarSiEstoyMute()
    {
        if (sliderValue == 0)
        {
            imageMute.enabled = true;
        }
        else
        {
            imageMute.enabled = false;
        }
    }
}
