using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField]
    private float minScale = 0.37f;

    [SerializeField]
    private float maxScale = 0.4f;

    void Start()
    {
        transform.localScale = Vector3.one * Mathf.Lerp(minScale, maxScale, Random.value);
    }
}
