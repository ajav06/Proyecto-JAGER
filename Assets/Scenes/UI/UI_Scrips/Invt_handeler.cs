using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invt_handeler : MonoBehaviour
{
    public GameObject analizar;
    public GameObject analizando;
    public void inv_toggle()
    {
        if (analizar.gameObject.activeSelf != true)
        {
            analizar.SetActive(true);
            analizando.SetActive(false);
        }
        else
        {
            if (analizando.gameObject.activeSelf != true)
            {
                analizar.SetActive(false);
                analizando.SetActive(true);
            }
        }
    }
}
