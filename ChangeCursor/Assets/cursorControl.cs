using UnityEngine;

public class cursorControl : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite defaultCursor;
    public Sprite tempCursor;
    public Sprite tempCursorAlt;
    void Start()
    {
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Cursor.visible = false;
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        if (Input.GetMouseButtonDown(0))
        {
            rend.sprite = tempCursor;
        } else if (Input.GetMouseButtonDown(1)) 
        {
            rend.sprite = tempCursorAlt;
        } else if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            rend.sprite = defaultCursor;
        }
    }
}
