using UnityEngine;
using System.Collections;

public class comportamentoBloco : MonoBehaviour {


    public float speed;
    public GameObject bloco;
    public GameObject explosao;
    public float current;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {       
        if (transform.position.y < -2.5f){
            GameObject tempBloco = Instantiate(explosao) as GameObject;
            tempBloco.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
            bloco.SetActive(false);
            tempBloco.SetActive(true);
        }
        else{
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
        }
	}
}
