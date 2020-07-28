using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Scripts : MonoBehaviour
{
    public GameObject perfil;
    public GameObject inventario;
    public GameObject estadisticas;
    public GameObject ranking;
    public GameObject amigos;
    public GameObject regresar_P;
    public GameObject world_ui;
    // Start is called before the first frame update
    public void ui_perfil()
    {
        if (perfil.gameObject.activeSelf != true)
        {
            perfil.gameObject.SetActive(true);
            inventario.gameObject.SetActive(false);
            estadisticas.gameObject.SetActive(false);
            ranking.gameObject.SetActive(false);
            amigos.gameObject.SetActive(false);
            world_ui.gameObject.SetActive(false);
        }
        else
        {
            perfil.gameObject.SetActive(false);
            inventario.gameObject.SetActive(false);
            estadisticas.gameObject.SetActive(false);
            ranking.gameObject.SetActive(false);
            amigos.gameObject.SetActive(false);
            world_ui.gameObject.SetActive(true);
        }
    }
    public void ui_inventario()
    {
        if (inventario.gameObject.activeSelf != true)
            perfil.gameObject.SetActive(false);
            inventario.gameObject.SetActive(true);
            estadisticas.gameObject.SetActive(false);
            ranking.gameObject.SetActive(false);
            amigos.gameObject.SetActive(false);
            world_ui.gameObject.SetActive(false);
    }
    public void ui_estadisticas()
    {
        if (estadisticas.gameObject.activeSelf != true)
            perfil.gameObject.SetActive(false);
            inventario.gameObject.SetActive(false);
            estadisticas.gameObject.SetActive(true);
            ranking.gameObject.SetActive(false);
            amigos.gameObject.SetActive(false);
            world_ui.gameObject.SetActive(false);
    }
    public void ui_ranking()
    {
        if (ranking.gameObject.activeSelf != true)
            perfil.gameObject.SetActive(false);
            inventario.gameObject.SetActive(false);
            estadisticas.gameObject.SetActive(false);
            ranking.gameObject.SetActive(true);
            amigos.gameObject.SetActive(false);
            world_ui.gameObject.SetActive(false);
    }
    public void ui_amigos()
    {
        if (amigos.gameObject.activeSelf != true)
            perfil.gameObject.SetActive(false);
            inventario.gameObject.SetActive(false);
            estadisticas.gameObject.SetActive(false);
            ranking.gameObject.SetActive(false);
            amigos.gameObject.SetActive(true);
            world_ui.gameObject.SetActive(false);
    }
    public void regresar_p()
    {
        perfil.gameObject.SetActive(false);
        inventario.gameObject.SetActive(false);
        estadisticas.gameObject.SetActive(false);
        ranking.gameObject.SetActive(false);
        amigos.gameObject.SetActive(false);
        world_ui.gameObject.SetActive(true);
    }
    public void regresar_()
    {
        perfil.gameObject.SetActive(true);
        inventario.gameObject.SetActive(false);
        estadisticas.gameObject.SetActive(false);
        ranking.gameObject.SetActive(false);
        amigos.gameObject.SetActive(false);
        world_ui.gameObject.SetActive(false);
    }
}
