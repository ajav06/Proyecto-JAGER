using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto : MonoBehaviour
{
    private string codigo;
    private string nombre;
    private string descripcion;
    private Sprite sprite;
    private float puntuacion;
    private float tamaño;
    private ObjectCategory categoria;
    private Mechanics mecanica;

    public Objecto(string codigo, string nombre, string descripcion, Sprite sprite, float puntuacion, float tamaño, ObjectCategory categoria, Mechanics mecanica)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.sprite = sprite;
        this.puntuacion = puntuacion;
        this.tamaño = tamaño;
        this.categoria = categoria;
        this.mecanica = mecanica;
    }

    public string Codigo
    {
        get => codigo;
        set => codigo = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string Descripcion
    {
        get => descripcion;
        set => descripcion = value;
    }

    public Sprite Sprite
    {
        get => sprite;
        set => sprite = value;
    }

    public float Puntuacion
    {
        get => puntuacion;
        set => puntuacion = value;
    }

    public float Tamaño
    {
        get => tamaño;
        set => tamaño = value;
    }
    public ObjectCategory Categoria 
    { 
        get => categoria;
        set => categoria = value;
    }

    public Mechanics Mecanica 
    { 
        get => mecanica;
        set => mecanica = value;
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    private void OnMouseDown()
    {
        JagerSceneManager[] managers = FindObjectsOfType<JagerSceneManager>();
        foreach (JagerSceneManager jagerSceneManager in managers)
        {
            if (jagerSceneManager.gameObject.activeSelf)
            {
                jagerSceneManager.objectTapped(this.gameObject);
            }
        }
    }
}
