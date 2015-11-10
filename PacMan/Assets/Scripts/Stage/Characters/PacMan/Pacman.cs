using UnityEngine;
using System.Collections;

public class Pacman: MonoBehaviour
{
	bool rightMovement = false;
    bool leftMovement = false;
    bool forwardMovement = true;
    bool backMovement = false;
    public float speed = 5.0f;
    public Transform spawnPoint;
    public AudioClip death;
    private AudioSource source;
    private AudioSource sourci;
    public AudioClip move;
    bool playSound = true;

    void Start()
    {
        source = GetComponent<AudioSource>();
        sourci = GetComponent<AudioSource>();
    }
    void Update()
    {
        //To do list on bool true
        IfTrue();

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.right);
            rightMovement = true;
            leftMovement = false;
            forwardMovement = false;
            backMovement = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = Quaternion.AngleAxis(-90, Vector3.left);
            leftMovement = true;
            rightMovement = false;
            forwardMovement = false;
            backMovement = false;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            forwardMovement = true;
            rightMovement = false;
            leftMovement = false;
            backMovement = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            transform.rotation = Quaternion.AngleAxis(-180, Vector3.back);
            backMovement = true;
            rightMovement = false;
            forwardMovement = false;
            leftMovement = false;
        }
    }

    //All movement false
       void AllFalse ()
        {
            forwardMovement = false;
            backMovement = false;
            leftMovement = false;
            rightMovement = false;
        }

        //This is a to do list
        void IfTrue()
        {
            if (forwardMovement == true)
                transform.Translate(Vector3.forward * Time.deltaTime * speed);

            if (backMovement == true)
                transform.Translate(Vector3.back * Time.deltaTime * speed);

            if (leftMovement == true)
                transform.Translate(Vector3.left * Time.deltaTime * speed);

            if (rightMovement == true)
                transform.Translate(Vector3.right * Time.deltaTime * speed);

            if (playSound == true)
                sourci.PlayOneShot(move, 1f);
    }

        //Teleportation och play sound on Enemy collide
        void OnCollisionEnter(Collision col)
        {
        if (col.gameObject.tag == "Enemy")
        {
            gameObject.transform.position = spawnPoint.transform.position;
            source.PlayOneShot(death, 1f);
            AllFalse();
            sourci.mute = !sourci.mute;
        }
        }
}
