using UnityEngine;
using System.Collections;

public class ColliderController : MonoBehaviour
{
    public Transform door;
    private bool open = false;

    void Update()
    {
        if (open)
        {
            door.position = new Vector3(door.position.x + 5.2f * Time.deltaTime, door.position.y, door.position.z);

            if (door.position.x >= 2.7f)
                open = false;
        }
    }

    void OnTriggerEnter()
    {
        open = true;
        Debug.Log("Abrir puerta");
    }
}
