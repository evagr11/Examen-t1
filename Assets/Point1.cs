using UnityEngine;

public class Point1 : MonoBehaviour
{
    private float minX1 = -6f;
    private float maxX1 = 6f;
    private float minY1 = -4.5f;
    private float maxY1 = 4.5f;

    private float minX2 = -6f;
    private float maxX2 = 6f;
    private float minY2 = -4.5f;
    private float maxY2 = 4.5f;

    [SerializeField] GameObject point1;
    [SerializeField] GameObject point2;

    private bool pointOnPlayer;

    // Start is called before the first frame update
    void Start()
    {
        RepositionPoints();
        pointOnPlayer = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 100 * Time.deltaTime);

        if (pointOnPlayer == true )
        {
            RepositionPoints();
            pointOnPlayer = false;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            point1.GetComponent<SpriteRenderer>().color = Color.cyan;
            pointOnPlayer = true;
        }
        if (collision.gameObject.CompareTag("Player2"));
        {
            point2.GetComponent<SpriteRenderer>().color = Color.cyan;
            pointOnPlayer = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            point1.GetComponent<SpriteRenderer>().color = Color.white;
            pointOnPlayer = false;
        }
        if (collision.gameObject.CompareTag("Player2"));
        {
            point2.GetComponent<SpriteRenderer>().color = Color.white;
            pointOnPlayer = false;
        }
    }

  
    private void RepositionPoints()
    {
        float X1 = Random.Range(minX1, maxX1);
        float Y1 = Random.Range(minY1, maxY1);
        point1.transform.position = new Vector2(X1, Y1);

        float X2 = Random.Range(minX2, maxX2);
        float Y2 = Random.Range(minY2, maxY2);
        point2.transform.position = new Vector2(X2, Y2);

      
    }
}





