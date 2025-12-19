using UnityEngine;

public class Star : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject deactivator;
    public GameObject activator;
    private SpriteRenderer star;
    public bool isSpecial = false;
    public bool isCollectable = true;
    public int requiredAmount = 1;


    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (isSpecial && isCollectable)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                deactivator.SetActive(false);
                activator.SetActive(true);
            }
        }
    }

    void Start()
    {
        star = this.GetComponent<SpriteRenderer>();
        if (isCollectable && !isSpecial)
        {
            star.color = Color.yellow;
            gameObject.tag = "Star";
        }

    }

    void Update()
    {
        if (isSpecial)
        {
            if (requiredAmount == gameManager.currentScore)
            {
                isCollectable = true;
                gameObject.tag = "Star";
            }
            else
            {
                isCollectable = false;
                gameObject.tag = "Untagged";
            }

            if (isCollectable)
            {
                star.color = Color.blue;

            }
            else
            {
                star.color = Color.softRed;
            }
        }


    }
}
