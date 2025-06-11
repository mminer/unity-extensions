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

### Bounds

```csharp
var randomPoint = someBounds.RandomPointInside();
```

### Component

```csharp
someComponent.AddComponent<MyComponent>();
someComponent.AddComponents<MyComponent, AnotherComponent>();
someComponent.GetOrAddComponent<MyComponent>();
someComponent.GetComponentsInChildrenIgnoringSef<MyComponent>();
someComponent.HasComponent<MyComponent>();
someComponent.TryGetComponentInChildren<MyComponent>(out var component);
```

### GameObject

```csharp
gameObject.AddComponents<MyComponent, AnotherComponent>();
gameObject.GetOrAddComponent<MyComponent>();
gameObject.HasComponent<MyComponent>();
gameObject.IsInCullingMask(Camera.main.cullingMask);
gameObject.SetLayerInChildren(LayerMask.NameToLayer("Ignore Raycast"));
gameObject.TryGetComponentInChildren<MyComponent>(out var component);
```

### LayerMask

```csharp
// Set camera culling mask to only "Ignore Raycast" and "UI".
LayerMask cullingMask = 0;
Camera.main.cullingMask = cullingMask.WithLayers("Ignore Raycast", "UI");

// Set camera culling mask to everything except "Ignore Raycast" and "UI".
LayerMask cullingMask = ~0;
Camera.main.cullingMask = cullingMask.WithoutLayers("Ignore Raycast", "UI");
```

### Quaternion

```csharp
var newRotation = rotation.WithEulerX(90f);
var newRotation = rotation.WithEulerY(90f);
var newRotation = rotation.WithEulerZ(90f);
```

### Rigidbody

```csharp
// Change direction of movement without modifying speed.
rigidbody.ChangeDirection(Vector3.right);
```

### Transform

```csharp
transform.AddChildren(gameObject1, gameObject2);
transform.Reset();
transform.ResetChildPositions();
transform.SetLocalPosition(y: 4f);
transform.SetPosition(z: 5f);
transform.SetChildLayers("Ignore Raycast");

```

### Vector2

```csharp
var absoluteVector = someVector2.Abs();
var newVector = someVector2.WithX(0.5f);
var newVector = someVector2.WithY(0.5f);
```

### Vector2Int

```csharp
var absoluteVector = someVector2Int.Abs();
var newVector = someVector2Int.WithX(1);
var newVector = someVector2Int.WithY(1);
```

### Vector3

```csharp
var absoluteVector = someVector3.Abs();
var newVector = someVector3.WithX(0.5f);
var newVector = someVector3.WithY(0.5f);
var newVector = someVector3.WithZ(0.5f);

// Find closest position.
var otherPositions = someTransforms.Select(t => t.position);
transform.position.GetClosest(otherPositions);

// Swizzle operations.
var xy = someVector3.XY();
var xz = someVector3.XZ();
// ... and so forth for all combinations.
```

### Vector3Int

```csharp
var absoluteVector = someVector3Int.Abs();
var newVector = someVector3Int.WithX(1);
var newVector = someVector3Int.WithY(1);
var newVector = someVector3Int.WithZ(1);

// Swizzle operations.
var xy = someVector3Int.XY();
var xz = someVector3Int.XZ();
// ... and so forth for all combinations.
```

### Vector4

```csharp
var absoluteVector = someVector4.Abs();
var newVector = someVector4.WithX(0.5f);
var newVector = someVector4.WithY(0.5f);
var newVector = someVector4.WithZ(0.5f);
var newVector = someVector4.WithW(0.5f);
```
