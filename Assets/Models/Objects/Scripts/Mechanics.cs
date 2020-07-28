using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics : MonoBehaviour
{
    private string codigo;
    private string descripcion;

    public Mechanics(string codigo, string descripcion)
    {
        this.codigo = codigo;
        this.descripcion = descripcion;
    }

    public string Codigo 
    { 
        get => codigo;
        set => codigo = value;
    }

    public string Descripcion 
    { 
        get => descripcion;
        set => descripcion = value;
    }
}
