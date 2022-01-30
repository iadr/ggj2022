using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class corazones : MonoBehaviour
{
    public Sprite ImgCorazon;
    public Image[] ImgContenedores;
    private int contadorVida = 4;


    // Start is called before the first frame update
    void Start()
    {

        foreach (var c in ImgContenedores)
        {
            c.sprite = ImgCorazon;
        }
        reiniciar();
    }
    //-----------------------------------------quita una vida
    public void quitarCorazon() {
        ImgContenedores[contadorVida--].enabled = false;
    }
    //----------------------------------------resetea los corazones
    public void reiniciar()
    {
        foreach (var c in ImgContenedores)
        {
            c.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
