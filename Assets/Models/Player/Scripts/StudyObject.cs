using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyObject : MonoBehaviour
{
    private string codigo;
    private Objecto objecto;
    private Time hora_inicio;
    private Time hora_fin;

    public StudyObject(string codigo, Objecto objecto, Time hora_inicio, Time hora_fin)
    {
        this.codigo = codigo;
        this.objecto = objecto;
        this.hora_inicio = hora_inicio;
        this.hora_fin = hora_fin;
    }

    public string Codigo 
    { 
        get => codigo; 
        set => codigo = value; 
    }

    public Objecto Objecto 
    { 
        get => objecto; 
        set => objecto = value; 
    }

    public Time Hora_inicio 
    {
        get => hora_inicio;
        set => hora_inicio = value;
    }

    public Time Hora_fin 
    { 
        get => hora_fin;
        set => hora_fin = value;
    }
}
