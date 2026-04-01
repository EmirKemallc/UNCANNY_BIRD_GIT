using UnityEngine;
using System.Collections.Generic;

namespace PatternMethod
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance;

        private Dictionary<string, Queue<GameObject>> pools = new Dictionary<string, Queue<GameObject>>();

        public GameObject pipePrefab;

        void Start()
        {
            CreatePool(pipePrefab, 10);
            
        }
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void CreatePool(GameObject prefab, int size)
        {
            string key = prefab.name;

            if (pools.ContainsKey(key)) return;

            pools[key] = new Queue<GameObject>();

            for (int i = 0; i < size; i++)
            {
                GameObject obj = Instantiate(prefab);
                obj.name = key;
                obj.SetActive(false);
                obj.transform.SetParent(transform);

                pools[key].Enqueue(obj);
            }
        }

        public GameObject Get(string prefabName)
        {
            if (!pools.ContainsKey(prefabName) || pools[prefabName].Count == 0)
            {
                Debug.LogWarning("Pool boş: " + prefabName);
                return null;
            }

            GameObject obj = pools[prefabName].Dequeue();
            obj.SetActive(true);
            return obj;
        }

        public void Return(GameObject obj)
        {
            string key = obj.name;

            obj.SetActive(false);
            obj.transform.SetParent(transform);

            pools[key].Enqueue(obj);
        }
    }
}