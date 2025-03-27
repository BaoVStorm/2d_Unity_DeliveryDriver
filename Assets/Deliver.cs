using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Deliver : MonoBehaviour
{
    [SerializeField] float destroyObject = 0.5f;
    [SerializeField] Color32 colorHasPackage = new Color32(1,1,1,1);
    [SerializeField] Color32 colorNoHasPackage = new Color32(1, 1, 1, 1);

    private SpriteRenderer spriteRenderer;

    bool hasPackage ;

    // Start is called before the first frame update
    void Start()
    {
        hasPackage = false;
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Buff me!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "package" && !hasPackage) {
            Debug.Log("pick package !!");
            hasPackage = true;
            spriteRenderer.color = colorHasPackage;
            Destroy(collision.gameObject, destroyObject);
        }

        if(collision.tag == "destination" && hasPackage) {
            hasPackage = false;
            spriteRenderer.color = colorNoHasPackage;
            Debug.Log("Deliver package !!");
        }
    }
}
