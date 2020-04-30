using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle1 : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject gameObjectTodrag;
    public Vector3 GOcenter; //Centro do objeto
    public Vector3 touchPosition; //Touch ou posição do Click
    public Vector3 offset;//vector entre touchpoint/mouseclick para o Centro do Objeto
    public Vector3 newGOCenter; //novo Centro do objeto

    RaycastHit hit; //Armazena informação que pegou o objeto
    public bool draggingMode = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barreira"))
        {
            transform.position = new Vector3(-5.704f, -2.833f, 0f);
        }

        if (other.CompareTag("Final"))
        {
            Debug.Log("Ganhou");
        }
    }

    public void Update()
    {
       foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                //Quando há um toque
                case TouchPhase.Began:
                    //converte a posição do toque para um Ray
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);

                    //Se o ray acertar (hit) o Collider (não 2DCollider)
                    // if (Physics.Raycast(ray, out hit))
                    if (Physics.SphereCast(ray, 0.3f, out hit))
                    {
                        gameObjectTodrag = hit.collider.gameObject; //mudar para varios objetos
                        GOcenter = hit.collider.gameObject.transform.position;
                        touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        offset = touchPosition - GOcenter;
                        draggingMode = true;
                    }
                    break;

                case TouchPhase.Moved:
                    if (draggingMode)
                    {
                        touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        newGOCenter = touchPosition - offset;
                        gameObject.transform.position = new Vector3(newGOCenter.x, newGOCenter.y, GOcenter.z);
                    }
                    break;

                case TouchPhase.Ended:
                    draggingMode = false;
                    break;
            }
        }
    }

    public void sairPuzzle()
    {
        SceneManager.LoadScene("Sala Principal");
    }
}