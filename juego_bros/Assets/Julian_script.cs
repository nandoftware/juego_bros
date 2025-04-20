using UnityEngine;

public class Julian_script : MonoBehaviour
{
    public int Julian_score = 0;
    public SpriteRenderer spriteRenderer;

    public Rigidbody2D rigidBody;

    float speed_yt = 30f;

    void Start(){
        Debug.Log("¡Hola Mundo! -_- Soy falsísimo, pero Alan me gana.");
        
        rigidBody = GetComponent<Rigidbody2D>();

    }

    void Update(){
        
        float xpos = Input.GetAxis("Horizontal");

        Vector2 vector2 = new Vector2(xpos, 0);
        
        Vector2 posicion_Julian = transform.position;
    
        rigidBody.MovePosition(posicion_Julian + vector2 * speed_yt * Time.deltaTime);

    }

}
