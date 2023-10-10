using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPosition : MonoBehaviour
{
    private Vector3 _position;
    public GridLayout gridLayout;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickDetection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            _position = Camera.main.ScreenToWorldPoint(mousePos);

            Vector3Int cellPosition = gridLayout.WorldToCell(_position);
            //mousePos = 

        }
    }
}
