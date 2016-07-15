using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawnObject : MonoBehaviour {

    public float maxWidth;
    public float minWidth;
    public float rateSpawn;
    private float currentSpawn;
    public int maxBloco;

    public GameObject prefab;
    public GameObject prefabExp;

    public List<GameObject> bloco;

   
    // Use this for initialization
    void Start () {

        for (int i = 0; i < maxBloco; i++){
            GameObject tempBloco = Instantiate(prefab) as GameObject;
            bloco.Add(tempBloco);
            tempBloco.SetActive(false);
        }

	}
	
	// Update is called once per frame
	void Update () {
        currentSpawn += Time.deltaTime;
        if (currentSpawn > rateSpawn){
            currentSpawn = 0;
            Spawn();
        }
	}

    private void Spawn(){
        float randPosition = Random.Range(minWidth, maxWidth);
        GameObject tempBloco = null;

        for (int i = 0; i < maxBloco; i++)
        {
            if (bloco[i].activeSelf == false)
            {
                tempBloco = bloco[i];
                break;
            }
        }

        if (tempBloco != null){
            tempBloco.transform.position = new Vector3(randPosition, transform.position.y, transform.position.z);
            tempBloco.SetActive(true);
        }
    }
}
