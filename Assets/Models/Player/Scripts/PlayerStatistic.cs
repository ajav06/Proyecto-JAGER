using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatistic : MonoBehaviour
{
    private Statistic estadistica;
    private float cant_mejoras;
    private float punt_actual;

    public PlayerStatistic(Statistic estadistica, float cant_mejoras, float punt_actual)
    {
        this.estadistica = estadistica;
        this.cant_mejoras = cant_mejoras;
        this.punt_actual = punt_actual;
    }

    public float Cant_mejoras
    {
        get => cant_mejoras;
        set => cant_mejoras = value;
    }

    public float Punt_actual
    {
        get => punt_actual;
        set => punt_actual = value;
    }

    public Statistic Estadistica 
    { 
        get => estadistica;
        set => estadistica = value;
    }
}

