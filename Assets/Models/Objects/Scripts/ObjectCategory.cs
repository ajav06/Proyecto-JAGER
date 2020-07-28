using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCategory : MonoBehaviour
{
    private string codigo;
    private string nombre;
    private string descripcion;
    private Sprite icono;
    private Career proficiencia;
    private Career debilidad;

    public ObjectCategory(string codigo, string nombre, string descripcion, Sprite icono, Career proficiencia, Career debilidad)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.icono = icono;
        this.proficiencia = proficiencia;
        this.debilidad = debilidad;
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

    public Sprite Icono
    { 
        get => icono;
        set => icono = value;
    }

    public Career Proficiencia
    { 
        get => proficiencia;
        set => proficiencia = value;
    }

    public Career Debilidad
    {
        get => debilidad;
        set => debilidad = value;
    }
}
