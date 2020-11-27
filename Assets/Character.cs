using System.Collections;
using System.Collections.Generic;
using Scrips;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
    private List<Item> items;
    
    public float Speed=6;



    // Private variables
    CharacterController ch;
    Vector2 _input;

    private void Awake()
    {
        items = new List<Item>();
        ch = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _input.x = Input.GetAxis("Horizontal");
        _input.y = Input.GetAxis("Vertical");

        if (_input.sqrMagnitude > 0&&ch!=null)
        {
            // ch.Move
            ch.Move(new Vector3(_input.x, 0, _input.y)*Speed*Time.deltaTime);
        }

    }



    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.LogError($"You add item with name {items[items.Count-1].Name}");
    }
}
