
# Unity Test Framework Examples

According to the [documentation](https://docs.unity3d.com/Packages/com.unity.test-framework@1.4/manual/index.html) the Unity Test Framework (UTF) enables Unity users to test their code in both Edit Mode and Play Mode, and also on target platforms such as Standalone, Android, iOS, etc.

This repository provides basic examples for unit testing in Unity by using UTF. Example cases are from basic to intermediate levels and don't cover advanced topics.

## Example Cases

This repository covers basics of both play mode and edit mode tests. It provides test cases with **TestCase**, **TestCaseSource**, **Values** and **ValueSource** attributes. Also, it has an example for **IMonoBehaviourTest** interface for direct testing of Mono Behaviors.

## Unit Tests and Singleton Pattern

Singleton is one of the most controversial patterns for the software developers. For some of the developers, it isn’t even a pattern, it is an anti-pattern. Also, unit tests are the most common examples of showing how unpleasant singleton is. So, for most, it is accepted that using singletons is a bad practice for unit testing.

On the other hand, this repository provides an elegant usage of singletons with unit tests. In Unity Test Framework, there is no acceptable way of accessing (referencing) to objects which are already in the scene. [This example](https://docs.unity3d.com/Packages/com.unity.test-framework@1.4/manual/course/scene-based-tests.html) which is in the official documentation uses ```GameObject.Find()``` to access scene objects, however it’s clearly a bad practice, because the name of the object can be changed anytime. In this repository, test bridges which are derived from singleton pattern are used to access objects from scene. It is a rare but highly effective partnership of singletons and unit tests.
