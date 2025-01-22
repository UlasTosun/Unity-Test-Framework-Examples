using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;



// By using IMonoBehaviourTest, we can control the test from the MonoBehaviour by using methods such as Start, Update, etc.
public class MonoBehaviourToTest : MonoBehaviour, IMonoBehaviourTest {

    // IsTestFinished is a property of IMonoBehaviourTest, the test is finished when this property is set to true by user
    public bool IsTestFinished { get; private set; }



    void Update () {

        if (Input.GetKey(KeyCode.DownArrow))
            Move(Vector3.down);
        if (Input.GetKey(KeyCode.UpArrow))
            Move(Vector3.up);
        if (Input.GetKey(KeyCode.LeftArrow))
            Move(Vector3.left);
        if (Input.GetKey(KeyCode.RightArrow))
            Move(Vector3.right);

        // If the user presses the space key, the test is finished
        if (Input.GetKeyDown(KeyCode.Space)) {
            IsTestFinished = true; // first, finish the test
            Assert.AreNotEqual(Vector3.zero, transform.position, "Move with arrows. Position should NOT be at the origin."); // then, assert the test result
        }

    }



    private void Move(Vector3 direction) {
        transform.position += direction * Time.deltaTime;
        
    }



}
