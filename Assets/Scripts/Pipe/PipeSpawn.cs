using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _PipesPrefab;
    [SerializeField] private float _PipeInterval = 2f;

    // Un grand merci à la doc d'Unity pour l'"InvokeRepeating" ! 
    private void Start()
    {
        GameManager.Instance.Score = 0;
        InvokeRepeating("SpawnRandomPipeAtLocation", 0f, _PipeInterval);
    }

    void SpawnRandomPipeAtLocation()
    {
        if (GameManager.Instance.IsPaused) return;

        if (_PipesPrefab.Length > 0)
        {
            int randomIndex = Random.Range(0, _PipesPrefab.Length);

            GameObject selectedPipe = _PipesPrefab[randomIndex];

            Instantiate(selectedPipe, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Prefab list is empty");
        }
    }
}
