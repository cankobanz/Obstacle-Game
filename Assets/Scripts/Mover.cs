using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    int count = 1;
    [SerializeField] float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xVar = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zVar = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yVar = Input.GetAxis("Jump") * Time.deltaTime;
        transform.Translate(xVar, yVar, zVar);

    }
}