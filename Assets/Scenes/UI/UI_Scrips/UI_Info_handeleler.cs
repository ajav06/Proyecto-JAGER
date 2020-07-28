using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Info_handeleler : MonoBehaviour
{
    [SerializeField]
    private Player player;
    public Text nombre;
    public Text apelllido;
    public Text username;
    public Career carrera;
    public float puntuacion;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
        player.Nombre = nombre.text;
    }

}
