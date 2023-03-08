using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    //creo los eventos que van a representar el estado de mi aplicacion
    public event Action OnMainMenu;
    public event Action OnItemMenu;
    public event Action OnARPosition;

    public static GameManager instance;

    private void Awake()

    {
        if (instance == null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    //Al iniciarse la aplicacion llama al evento main menu

    void Start()
    {
        MainMenu();
    }

    //Creo las funciones para poder llamar a los eventos

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Menu Activado");
    }

    public void ItemMenu()
    {
        OnItemMenu?.Invoke();
        Debug.Log("item activado");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position activado");
    }

    public void CloseApp()  //Cerrar Aplicación
    {
        Application.Quit();
    }

}
