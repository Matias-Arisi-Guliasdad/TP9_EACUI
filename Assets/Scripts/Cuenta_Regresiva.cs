using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cuenta_Regresiva : MonoBehaviour
{
    public TMP_InputField input_IngreseNumero;
    public TextMeshProUGUI txt_Resultado;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CuentaRegresiva()
    {
        int numero = int.Parse(input_IngreseNumeros.text);
        numero = numero - 1;
        resultado_text.text = numero.ToString();
    }
}
