using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControler : MonoBehaviour
    {
    public int speed;
    Vector3 target;
    Vector3 posToGo;
    GameObject taquilla;
    bool control = false;
    public TMP_Text text;
    public string myText;
    ControlObjetos controlObjetos;
    Camera cam;
    public AudioClip openTaquilla;
    public AudioClip closeTaquilla;
    public AudioSource audioSource;
    GameObject llave;

    private void Awake()
    {
        //controlObjetos = GameObject.Find("Scripts").GetComponent(typeof(ControlObjetos)) as ControlObjetos;
        audioSource = GetComponent<AudioSource>();
        llave = GameObject.FindGameObjectWithTag("llave");
        llave.SetActive(false);
        taquilla = FindObjectOfType<ObjetosEscenario>().gameObject;
    }
    void Start()
    {
        target = transform.position;
        myText = "";
    }
    void Update()
    {
        text.text = myText;

        if (Input.GetMouseButtonUp(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        posToGo = new Vector3(target.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, posToGo, speed * Time.deltaTime);

        if (posToGo.x < gameObject.transform.position.x) //movimiento hacía la izquierda
        {
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        
        }
        else if (target.x > gameObject.transform.position.x) //movimiento hacía la derecha
        {
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (transform.position == posToGo)  //Idle
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (posToGo.x <= 39.5 && posToGo.x >=19.5 && control == false) //TAQUILLA COLISIÓN
        {
            audioSource.PlayOneShot(openTaquilla);
            gameObject.GetComponent<Animator>().SetBool("open", true);
            taquilla.gameObject.GetComponent<Animator>().SetInteger("open", 1);
            myText = "Has encontrado una llave";
            llave. SetActive(true);
            StartCoroutine("Esperar");
            control = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)   //TAQUILLA COLISIÓN   
    {
        if (control == true)
        {
            control = false;
            gameObject.GetComponent<Animator>().SetBool("open", false);
            audioSource.PlayOneShot(closeTaquilla);
            taquilla.gameObject.GetComponent<Animator>().SetInteger("open", 2);
        }
    }

IEnumerator Esperar() //Corrutina para feedback textos
    {
        yield return new WaitForSeconds(5);
        myText = "";
    }
}
