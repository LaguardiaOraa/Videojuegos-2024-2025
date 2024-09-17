using UnityEngine;



public class Mult : MonoBehaviour
{
    public SpawnManagerScriptableObject spawn;
    private int posicion = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
            for (int i = 0; i < spawn.NumItems; i++)
            {
                posicion++;
                Instantiate(spawn.Objeto, new Vector3(posicion, 0, 0), Quaternion.identity);
            }
        }
    }
}
