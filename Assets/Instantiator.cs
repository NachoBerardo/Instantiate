using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour {

    public GameObject ObjectToClone;
    public int repeticiones;

    public void Clonar()
    {
        for(int i=1; i<=repeticiones; i++ )
        {
            Instantiate(ObjectToClone);
            Debug.Log("Hola");
        }
    }
}
