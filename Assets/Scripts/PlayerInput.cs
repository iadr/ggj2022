using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Player))]
public class PlayerInput : MonoBehaviour {

	Player player;
	public Animator animator;

	public int life = 5;

	void Start () {
		player = GetComponent<Player> ();
	}

	void Update () {

		if (life == 0) {
            //game over;
        }

		Vector2 directionalInput = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		player.SetDirectionalInput (directionalInput);

		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) {
			player.OnJumpInputDown ();
		}
		if (Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.W)) {
			player.OnJumpInputUp ();
		}

		if (Input.GetKeyDown (KeyCode.Q)) {
			animator.SetTrigger("shooting");
			player.Shoot (1); // FIRE
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			animator.SetTrigger("shooting");
			player.Shoot (0); // FROST
		}
	}

	void ReceiveDamage () {
		life --;
	}
}
