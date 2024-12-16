using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void ToggleGameObject(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
