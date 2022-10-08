using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisao : MonoBehaviour
{
    public ContactFilter2D filtro;
    private BoxCollider2D caixaColisao;
    private Collider2D[] hits = new Collider2D[10];
    // Start is called before the first frame update
    void Start()
    {
        caixaColisao = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        caixaColisao.OverlapCollider(filtro, hits);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
                continue;

            Debug.Log(hits[i].name);
            hits[i] = null;

        }
    }
}
