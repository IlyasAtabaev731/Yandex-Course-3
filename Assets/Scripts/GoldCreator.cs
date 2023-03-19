using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoldCreator : MonoBehaviour
{
    [SerializeField] private Resources _resources;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Gold _goldPrefab;
    [SerializeField] private ModelVariants _modelVariants;
    [SerializeField] private float _throwPower = 3f;

    public void CreateThrowedGold()
    {
        Gold newThrowedGold = Instantiate(_goldPrefab, _spawnPoint.position, Quaternion.identity);
        newThrowedGold.Resources = _resources;

        GameObject newModel = Instantiate(_modelVariants.CurrentSelected, newThrowedGold.transform);
        newThrowedGold.GetComponent<MeshCollider>().sharedMesh = newModel.GetComponent<MeshFilter>().sharedMesh;
        newModel.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
        Vector3 velocity = (new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f)));
        float power = _throwPower / velocity.magnitude;
        newThrowedGold.GetComponent<Rigidbody>().velocity = velocity * power;
    }
}
