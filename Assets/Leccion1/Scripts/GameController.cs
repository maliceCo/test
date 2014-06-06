using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    void Start()
    {
        string asterisc = "";
        string asterisc2 = "******";

        for (int i = 0, k = 5; i < 5; i++)
        {
            for (int j = 0; j <= i; j++)
                asterisc += "*";

            asterisc += "\n";
            asterisc2 += "\n";
            asterisc2 += asterisc2.Remove(k--);
        }

        Debug.Log(asterisc + asterisc2);
    }
}