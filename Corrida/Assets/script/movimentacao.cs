using UnityEngine;
using System.Collections;

public class movimentacao : MonoBehaviour {

    public float speed;
    public GameObject player;
    public float maxWidth;
    public float minWidth;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
    }
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Horizontal") * speed;
        player.transform.Translate(translation,0,0);

        if(player.transform.position.x > maxWidth){
            player.transform.position = new Vector2(maxWidth, -2.22f);
        }

        if (player.transform.position.x < minWidth){
            player.transform.position = new Vector2(minWidth, -2.22f);
        }

        Destroy(GetComponent<PolygonCollider2D>());        
        gameObject.AddComponent<PolygonCollider2D>().isTrigger = true;

    }

    void OnTriggerEnter2D(Collider2D col){
        player.SetActive(false);
        Application.LoadLevel("gameover");
    }
}
