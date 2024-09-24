using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middletrigger : MonoBehaviour
{
    public LogicSc logic;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
    logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicSc>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

    if (collision.gameObject.layer == 3) 
    {
        logic.addScore(1);
    }
        
    }
}
