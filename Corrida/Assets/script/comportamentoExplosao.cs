using UnityEngine;
using System.Collections;

public class comportamentoExplosao : MonoBehaviour {

    public GameObject bloco;
    private float current;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        current += Time.deltaTime;

        if (current > 1 ){
            bloco.SetActive(false);
        }
	}
}
