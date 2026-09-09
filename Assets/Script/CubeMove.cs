using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] bool useDeltaTime = true;
    [SerializeField] int targetFrameRate = 30;

    float elapsed;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (useDeltaTime)
            pos.x += speed * Time.deltaTime;
        else
            pos.x += speed;

        transform.position = pos;

        elapsed += Time.deltaTime;

        if (elapsed >= 5f)
        {
            Debug.Log($"{name}: {transform.position.x}");
            enabled = false;
        }
    }

}
