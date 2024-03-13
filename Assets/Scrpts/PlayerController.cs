using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class PlayerController : MonoBehaviour
{
	public float playerJumpForce = 5f;
	public float playerSpeed = 5f;
	public Sprite[] mySprites;
	private int index = 0;

	private Rigidbody2D myrigidbody2D;
	private SpriteRenderer mySpriteRenderer;
	public GameObject Bullet;
	public GameManager myGameManager;
    private AudioSource AudiodelJugadorSaltando;
	[SerializeField] private AudioClip SonidoPerdedor;
	private ControladorSonido controladorSonido;
	
	private float tiempoEntreDisparos;
	private float tiempoSiguienteDisparo;

	//private AudioSource AudiodelJugadorPerdiendo;

    // Start is called before the first frame update
    void Start()
    {
		myrigidbody2D = GetComponent<Rigidbody2D>();
		mySpriteRenderer = GetComponent<SpriteRenderer>();
        AudiodelJugadorSaltando = GetComponent<AudioSource>();
		controladorSonido = ControladorSonido.Instance;
		SonidoPerdedor = GetComponent<AudioClip>();
		myGameManager = FindObjectOfType<GameManager>();
		StartCoroutine(WalkCoRutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, playerJumpForce);
			AudiodelJugadorSaltando.Play();
		}
		myrigidbody2D.velocity = new Vector2(playerSpeed, myrigidbody2D.velocity.y);
		if (Input.GetKeyDown(KeyCode.E))
		{
			Instantiate(Bullet, transform.position, Quaternion.identity);
		}
    }

	IEnumerator WalkCoRutine()
	{
		yield return new WaitForSeconds(0.05f);
		mySpriteRenderer.sprite = mySprites[index];
		index++;
		if (index == 4)
		{
			index = 0;
		}
		StartCoroutine(WalkCoRutine());
	}

		void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("ZombieMale"))
		{
			PlayerDeath();
		}
		else if (collision.CompareTag("ZombieFemale"))
		{
			//Destroy(collision.gameObject);
			PlayerDeath();
		}
		else if (collision.CompareTag("DeathZone"))
		{
			PlayerDeath();
		}
	}

	void PlayerDeath()
	{
		SceneManager.LoadScene("SampleScene");
	}
}