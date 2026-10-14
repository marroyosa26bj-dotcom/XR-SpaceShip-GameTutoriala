using UnityEngine;

public class TrashCan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<TriggerZone>().onEnterEvent.AddListener(InsideTrash);
    }

    // Update is called once per frame
    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }
}
