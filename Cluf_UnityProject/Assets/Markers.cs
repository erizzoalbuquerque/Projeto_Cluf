using UnityEngine;

public class Markers : MonoBehaviour
{
    public Transform target;
    public float period = 1f;
    public Color color = Color.black;
    public Sprite sprite = null;
    public float size = 0.1f;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > period)
        {
            CreateMarker();
            timer = 0f;
        }

        timer += Time.deltaTime;
    }

    void CreateMarker()
    {
        GameObject marker = new GameObject("marker");

        marker.transform.position = target.position;
        marker.transform.rotation = target.rotation;
        marker.transform.localScale = Vector3.one * size;
        marker.transform.parent = this.transform;

        SpriteRenderer spriteRenderer = marker.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        spriteRenderer.color = color;
        spriteRenderer.sprite = sprite;
    }
}
