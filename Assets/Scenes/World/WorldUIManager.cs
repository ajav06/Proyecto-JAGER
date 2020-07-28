using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;

public class WorldUIManager : MonoBehaviour
{
    [SerializeField] private Text xpText;
    /*[SerializeField] private GameObject menu;*/

    private void Awake()
    {
        Assert.IsNotNull(xpText);
        /* Assert.IsNotNull(menu); */
    }

    private void Update()
    {
       updateXP();
    }

    public void updateXP()
    {
        xpText.text = GameManager.Instance.
            CurentPlayer.Puntuacion.ToString();
    }

    /*public void toggleMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }*/
}
