using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControlador : MonoBehaviour
{
[SerializeField]private Transform Jugador; 
 private void Update()
    {
        transform.position = new Vector3(Jugador.position.x,Jugador.position.y,transform.position.z);
    }
}
