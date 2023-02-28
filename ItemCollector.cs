using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int fresa = 0;

    [SerializeField] private TextMeshProUGUI fresaText;
    [SerializeField] private AudioSource RecogidaSonido;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Fresa"))
        {
            RecogidaSonido.Play();
            Destroy(collision.gameObject);
            fresa++;
            fresaText.text = "Fresa: " + fresa;
        }
    }
}
