using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rarity : MonoBehaviour
{
    private string codigo;
    private string nombre;
    private float probablilidad;

    public Rarity(string codigo, string nombre, float probablilidad)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.probablilidad = probablilidad;
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

    public float Probablilidad 
    {
        get => probablilidad; 
        set => probablilidad = value;
    }
}
