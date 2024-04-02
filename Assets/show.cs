using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class show : MonoBehaviour
{
    public GameObject activar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activar.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FirstPersonController fControl = other.gameObject.GetComponent<FirstPersonController>();
            fControl._input.shoot = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activar.SetActive(false);
            FirstPersonController fControl = other.gameObject.GetComponent<FirstPersonController>();
            fControl._input.shoot = false;
        }
    }
}
