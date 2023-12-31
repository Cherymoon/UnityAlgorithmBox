using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 2000; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            float radius;
            if (Random.value < 80)
            {
                radius = Random.Range(0.4f, 20f);
            }
            else
            {
                radius = Random.Range(1f, 50f);
            }


            sphere.transform.localScale = new Vector3(radius, radius, radius);
            sphere.transform.position = Random.insideUnitSphere * 4000;
        }
    }
}
