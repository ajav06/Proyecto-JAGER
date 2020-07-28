using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistic : MonoBehaviour
{
    private string codigo;
    private string nombre;
    private string descripcion;
    private float precio_base;
    private float incremento;
    private int paso;

    public Statistic(string codigo, string nombre, string descripcion, float precio_base, float incremento, int paso)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio_base = precio_base;
        this.incremento = incremento;
        this.paso = paso;
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

    public float Precio_base
    { 
        get => precio_base;
        set => precio_base = value;
    }

    public float Incremento
    {
        get => incremento;
        set => incremento = value;
    }

    public int Paso 
    {
        get => paso;
        set => paso = value;
    }
}
