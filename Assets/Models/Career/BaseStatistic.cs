using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatistic : MonoBehaviour
{
    private Statistic estadistica;
    private float statBase;

    public BaseStatistic(Statistic estadistica, float statBase)
    {
        this.estadistica = estadistica;
        this.statBase = statBase;
    }

    public Statistic Estadistica 
    { 
        get => estadistica; 
        set => estadistica = value; 
    }

    public float StatBase 
    { 
        get => statBase; 
        set => statBase = value; 
    }
}
