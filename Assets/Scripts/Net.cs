using UnityEngine;

public class Net : MonoBehaviour
{
    public GameObject dotPrefab;
    public int numberOfDots = 40;

    void Start()
    {
        float stepSize = 2f / numberOfDots;
        float y = -1;

        for (int i=0; i<numberOfDots; i++)
        {
            GameObject dotInstance = Instantiate<GameObject>(dotPrefab);
            dotInstance.transform.parent = transform;
            dotInstance.transform.localPosition = new Vector3(0, y, 0);
            y += stepSize;
        }
    }
}
