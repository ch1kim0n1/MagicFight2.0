using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject playerModel;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerModel.transform.position;
    }
}
