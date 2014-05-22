using UnityEngine;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    public List<string> enemigos;
    private List<string> amigos = new List<string>();

    private string enemigo = "";

    void Start()
    {
        enemigos.Add("Licantropo");

        Debug.Log(enemigo);
    }
}