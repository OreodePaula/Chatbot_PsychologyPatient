using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Selection : MonoBehaviour
{
    public GameObject Paciente1;
    public GameObject Paciente2;
    private int coso = 0;
 
    public void SelecciónPaciente1()
    {
        coso = 1;
    }
    public void SelecciónPaciente2()
    {
        coso = 2;
    }
    public void Prueba()
    {
        if ( coso == 1 )
        {
            Paciente1.SetActive(true);
        }
        else if ( coso == 2 )
        {
            Paciente2.SetActive(true);
        }
        this.gameObject.SetActive(false);
    }
}
