using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MoveMap : MonoBehaviour

{
    public Transform maps;
    private Vector3 positionMouse;

    private void Update()
    {
         if(Input.GetButton("Fire1"))
        {
            positionMouse = Input.mousePosition;

            Debug.Log(positionMouse);

            maps.position = maps.position + new Vector3(Input.mousePosition.x - positionMouse.x, Input.mousePosition.y - -positionMouse.y, Input.mousePosition.z - -positionMouse.z);
        }
    }
}
