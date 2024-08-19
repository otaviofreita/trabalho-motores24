using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //-1 esqueda, o nada, 1 direita
        float v = Input.GetAxis("Vertical");// -1 tras, 0 nada, 1 pra frente

        UnityEngine.Vector3 direcao = new Vector3(x:h, y:0, z:v);
        rb.AddForce(direcao * velocidade);
    }
}
