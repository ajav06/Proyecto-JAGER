using Proyecto26;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{

    private string username;
    private string nombre;
    private string apellido;
    private Sprite foto;
    private Career carrera;
    private String[] amigos;
    private PlayerStatistic[] stats;
    private Objecto[] inventario;
    private float puntuacion = 0;
    private Transaction[] transacciones;

    
    public Player(string username, string nombre, string apellido, Sprite foto, Career carrera, string[] amigos, PlayerStatistic[] stats, Objecto[] inventario, float puntuacion, Transaction[] transacciones)
    {
        this.username = username;
        this.nombre = nombre;
        this.apellido = apellido;
        this.foto = foto;
        this.carrera = carrera;
        this.amigos = amigos;
        this.stats = stats;
        this.inventario = inventario;
        this.puntuacion = puntuacion;
        this.transacciones = transacciones;
    }

    public string Username
    {
        get => username;
        set => username = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string Apellido
    {
        get => apellido;
        set => apellido = value;
    }

    public Sprite Foto
    {
        get => foto;
        set => foto = value;
    }

    public Career Carrera
    {
        get => carrera;
        set => carrera = value;
    }

    public float Puntuacion
    {
        get => puntuacion;
        set => puntuacion = value;
    }
    public string[] Amigos 
    { 
        get => amigos; 
        set => amigos = value; 
    }
    public PlayerStatistic[] Stats 
    { 
        get => stats; 
        set => stats = value;
    }
    public Objecto[] Inventario 
    { 
        get => inventario; 
        set => inventario = value; 
    }
    public Transaction[] Transacciones 
    { 
        get => transacciones; 
        set => transacciones = value; 
    }

    public void AddPuntuacion(int xp)
    {
        this.puntuacion += Mathf.Max(0, xp);
    }

    [Serializable]
    internal class PlayerData
    {
        private string username;
        private string nombre;
        private string apellido;
        private Sprite foto;
        private Career carrera;
        private String[] amigos;
        private PlayerStatistic[] stats;
        private Objecto[] inventario;
        private float puntuacion = 0;
        private Transaction[] transacciones;

        public PlayerData(Player player)
        {
            this.username = player.username;
            this.nombre = player.nombre;
            this.apellido = player.apellido;
            this.foto = player.foto;
            this.carrera = player.carrera;
            this.amigos = player.amigos;
            this.stats = player.stats;
            this.inventario = player.inventario;
            this.puntuacion = player.puntuacion;
            this.transacciones = player.transacciones;
        }

        public string Username { get => username; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public Sprite Foto { get => foto; }
        public Career Carrera { get => carrera; }
        public string[] Amigos { get => amigos; }
        public PlayerStatistic[] Stats { get => stats; }
        public Objecto[] Inventario { get => inventario; }
        public float Puntuacion { get => puntuacion; }
        public Transaction[] Transacciones { get => transacciones; }


    }

}