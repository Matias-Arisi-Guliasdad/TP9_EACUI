using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CuentaRegresiva : MonoBehaviour


{
    public TextMeshProUGUI numerodecrementado;
    public TMP_InputField ingresenumero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Cuenta_Regresiva()
    {
    int numero = int.Parse(ingresenumero.text);
    int resultado = numero - 1;
    numerodecrementado.text = "Resultado"+ numeroresultado.ToString();
    if(numero >0)
    {
        numero -=1;
    }
    else 
    {
        nuemro = 0;
    }
    ingresenumero.text = numero.ToString();
    numerodecrementado.text= "Resultado" + numero.ToString();
    }
}
