using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transaction : MonoBehaviour
{
    private string codigo;
    private string descripcion;
    private char tipo;
    private float monto;

    public Transaction(string codigo, string descripcion, char tipo, float monto)
    {
        this.codigo = codigo;
        this.descripcion = descripcion;
        this.tipo = tipo;
        this.monto = monto;
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

    public char Tipo 
    {
        get => tipo;
        set => tipo = value;
    }

    public float Monto
    {
        get => monto;
        set => monto = value;
    }
}
