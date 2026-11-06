using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Selection : MonoBehaviour
{
    public GameObject Paciente1;
    public GameObject Paciente2;
    private int Paciente = 0;
 
    public void SelecciónPaciente1()
    {
        Paciente = 1;
    }
    public void SelecciónPaciente2()
    {
        Paciente = 2;
    }
    public void Prueba()
    {
        if (Paciente == 1 )
        {
            Paciente1.SetActive(true);
        }
        else if (Paciente == 2 )
        {
            Paciente2.SetActive(true);
        }
        this.gameObject.SetActive(false);
    }
}
