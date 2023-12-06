using UnityEngine;

public class Paddle : MonoBehaviour
{
	protected Rigidbody2D _rigidbody;
	public float speed = 10f;

	[SerializeField]
	private AudioSource padleSound;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
	}
	private void OnCollisionEnter2D(Collision2D other) 
	{
		if (other.gameObject.name == "Ball")
		{
		padleSound.Play();
		}
	}	
}
