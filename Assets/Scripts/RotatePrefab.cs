using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePrefab : MonoBehaviour
{
    [SerializeField]
    private Button virarMesa;
    [SerializeField]
    private Text help;
    [SerializeField]
    private GameObject mesa;


    void Start()
    {
        virarMesa.onClick.AddListener(VirarAMesa);
    }

    void VirarAMesa(){
        var lookPos = mesa.transform.position;
        lookPos.x = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        rotation *= Quaternion.Euler(-90, 0, 0); // this adds a 90 degrees Y rotation

        mesa.transform.rotation = rotation;

    }

    void Update()
    {
        help.text = "UM CU: " + mesa.transform.rotation;
    }
}
