using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class acciones : MonoBehaviour
{

    public Animator animacionMusica;
    public Animator animacionFondo;

    public void CargarJuego()
    {

        StartCoroutine(cargarSonidoYJuego());
    }

    IEnumerator cargarSonidoYJuego()
    {
        //yield return new WaitForSeconds(0.4f); // wait time        
        animacionMusica.SetTrigger("salir");
        animacionFondo.SetTrigger("salirBlack");
        //Application.LoadLevel(level01);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
    
}
