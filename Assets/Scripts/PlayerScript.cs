using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2(50,50); //La vitesse de déplacement du joueur

	private Vector2 movement; //Stockage du mouvement ((x2-x1), (y2-y1))


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");


		movement = new Vector2(speed.x * inputX , speed.y * inputY); // On enregistre le mouvement dans le vecteur

	}

	void FixedUpdate() {


		GetComponent<Rigidbody2D>().velocity = movement;

	}

}
