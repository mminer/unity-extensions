# Unity Extensions

[Extension methods](http://en.wikipedia.org/wiki/Extension_method) for Unity
types. If you find yourself thinking "gee, I wish `GameObject` / `Vector3` /
`Quaternion` had this method," this might be the package for you.


## Installing

Add the package to your project via
[UPM](https://docs.unity3d.com/Manual/upm-ui.html) using the Git URL:

```
https://github.com/mminer/unity-extensions.git
```

1. Open the Package Manager window in Unity (*Window > Package Manager*)
2. Click the "+" button in the top-left corner
3. Select "Install package from git URL..."
4. Enter the above Git URL
5. Click "Install"

Alternatively, add the following line to your `Packages/manifest.json` file:

```json
{
  "dependencies": {
    "com.matthewminer.unity-extensions": "https://github.com/mminer/unity-extensions.git",
    ...
  }
}
```

You can also clone the repository and point UPM to your local copy.


## Using

The classes are in the `UnityExtensions` namespace, so you must first import
them.

```csharp
using UnityExtensions;
```

Now call the extensions on the appropriate object type.

```csharp
void Awake ()
{
    var someComponent = gameObject.GetOrAddComponent<MyComponent>();
}
```


## Extensions

```csharp
Bounds.RandomPointInside();

Color.WithR(float r);
Color.WithG(float g);
Color.WithB(float b);
Color.WithA(float a);

Component.AddComponent<T>();
Component.AddComponents<T1, T2>();
Component.GetComponentsInChildrenIgnoringSelf<T>(bool includeInactive = false);
Component.GetOrAddComponent<T>();
Component.HasComponent<T>();
Component.TryGetComponentInChildren<T>(out T component);

GameObject.AddComponents<T1, T2>();
GameObject.GetOrAddComponent<T>();
GameObject.HasComponent<T>();
GameObject.IsInCullingMask(LayerMask cullingMask);
GameObject.SetLayerInChildren(int layer);
GameObject.TryGetComponentInChildren<T>(out T component);

LayerMask.WithLayers(params int[] layers);
LayerMask.WithLayers(params string[] layerNames);
LayerMask.WithoutLayers(params int[] layers);
LayerMask.WithoutLayers(params string[] layerNames);

Quaternion.WithEulerX(float x);
Quaternion.WithEulerY(float y);
Quaternion.WithEulerZ(float z);

Rigidbody.ChangeDirection(Vector3 direction);

Transform.AddChildren(params GameObject[] children);
Transform.AddChildren(params Component[] children);
Transform.Reset(Space space = Space.Self);
Transform.ResetChildPositions(bool recursive = false);
Transform.SetChildLayers(string layerName, bool recursive = false);
Transform.SetLocalPosition(float? x = null, float? y = null, float? z = null);
Transform.SetPosition(float? x = null, float? y = null, float? z = null);
Transform.SetX(float x);
Transform.SetY(float y);
Transform.SetZ(float z);

Vector2.Abs();
Vector2.Ceil();
Vector2.Floor();
Vector2.GetClosest(IEnumerable<Vector2> otherPositions);
Vector2.Round();
Vector2.WithX(float x);
Vector2.WithY(float y);

Vector2Int.Abs();
Vector2Int.WithX(int x);
Vector2Int.WithY(int y);

Vector3.Abs();
Vector3.Ceil();
Vector3.Floor();
Vector3.GetClosest(IEnumerable<Vector3> otherPositions);
Vector3.Round();
Vector3.WithX(float x);
Vector3.WithY(float y);
Vector3.WithZ(float z);

// Swizzle operations:
Vector3.XY();
Vector3.XZ();
// ... and so forth for all combinations.

Vector3Int.Abs();
Vector3Int.WithX(int x);
Vector3Int.WithY(int y);
Vector3Int.WithZ(int z);

// Swizzle operations:
Vector3Int.XY();
Vector3Int.XZ();
// ... and so forth for all combinations.

Vector4.Abs();
Vector4.Ceil();
Vector4.Floor();
Vector4.Round();
Vector4.WithX(float x);
Vector4.WithY(float y);
Vector4.WithZ(float z);
Vector4.WithW(float w);
```
