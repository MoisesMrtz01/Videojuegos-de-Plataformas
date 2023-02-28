using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
   private AudioSource MetaSonido;

   private bool NivelFull = false;

   private void Start()
    {
        MetaSonido = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Jugador" && !NivelFull)
        {
            MetaSonido.Play();
            NivelFull = true;
            Invoke ("NivelCompletado", 2f);
        }
    }

    private void NivelCompletado()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
