using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinScript : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = newPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "win")
        {
            SceneManager.LoadScene(2);
        }
        Destroy(gameObject);

    }


}
