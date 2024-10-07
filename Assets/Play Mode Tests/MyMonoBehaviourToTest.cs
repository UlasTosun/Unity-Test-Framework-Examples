using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;



// By using IMonoBehaviourTest, we can control the test from the MonoBehaviour by using methods such as Start, Update, etc.
public class MyMonoBehaviourToTest : MonoBehaviour, IMonoBehaviourTest {

    // IsTestFinished is a property of IMonoBehaviourTest, the test is finished when this property is set to true by user
    public bool IsTestFinished { get; private set; }



    void Update () {

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= new Vector3(1, 0, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        // If the user presses the space key, the test is finished
        if (Input.GetKeyDown(KeyCode.Space)) {
            IsTestFinished = true; // first, finish the test
            Assert.AreEqual(new Vector3(0, 0, 0), transform.position); // then, assert the test result
        }

    }



}
