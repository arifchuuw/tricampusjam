using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public RectInt PlayRegion;
    
    private void Awake()
    {
        gameObject.AddComponent<GridManager>();
        GridManager.SetRect(PlayRegion);
        gameObject.AddComponent<TargetManager>();
        gameObject.AddComponent<AIManager>();
        gameObject.AddComponent<SpawnerManager>();
        gameObject.AddComponent<RoundManager>();
    }
}
