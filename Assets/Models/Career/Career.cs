using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Career : MonoBehaviour
{
    private string codigo;
    private string nombre;
    private string siglas;
    private string color;
    private BaseStatistic[] stats;

    public Career(string codigo, string nombre, string siglas, string color, BaseStatistic[] stats)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.siglas = siglas;
        this.color = color;
        this.stats = stats;
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

    public string Siglas 
    { 
        get => siglas; 
        set => siglas = value; 
    }

    public string Color 
    { 
        get => color; 
        set => color = value;
    }

    public BaseStatistic[] Stats 
    { 
        get => stats; 
        set => stats = value;
    }

}
