using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour {

    public GameObject[] fruitPrefabs;
	void Start () {
        StartSpawnFruit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //开始生成水果
    public void StartSpawnFruit()
    {
        StartCoroutine(SpawmFruit());
    }
    // 生成水果
    IEnumerator SpawmFruit()
    {
        while (true)
        {
            //随机生成水果
            GameObject fruit=Instantiate(fruitPrefabs[Random.Range(0, fruitPrefabs.Length - 1)]);
            // 获取水果的刚体
            Rigidbody rbody = fruit.GetComponent<Rigidbody>();
             //给水果一个速度
            rbody.velocity=new Vector3(0,5f,0);
            //设置一个角速度，翻滚的效果
            rbody.angularVelocity = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
            rbody.useGravity = true;
            //给水果一个随机范围内的位置
            Vector3 Position = transform.position + transform.right * Random.Range(-1f, 1f);
            fruit.transform.position=Position;
            yield return new WaitForSeconds(3.0f);//每隔三秒调用一次该携程
        }
    }
}
