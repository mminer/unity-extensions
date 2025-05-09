# Unity Extensions

Here we have [extension methods](http://en.wikipedia.org/wiki/Extension_method)
for Unity objects (`GameObject`, `Vector3`, etc.). These add useful
functionality that I often end up reimplementing in every game I make.


## Installing

Add the package to your project via
[UPM](https://docs.unity3d.com/Manual/upm-ui.html) using the Git URL
https://github.com/mminer/unity-extensions.git. You can also clone the
repository and point UPM to your local copy.


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


## Included Extensions

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
var newVector = someVector2.WithX(0.5f);
var newVector = someVector2.WithY(0.5f);
```

### Vector2Int

```csharp
var newVector = someVector2Int.WithX(1);
var newVector = someVector2Int.WithY(1);
```

### Vector3

```csharp
var newVector = someVector3.WithX(0.5f);
var newVector = someVector3.WithY(0.5f);
var newVector = someVector3.WithZ(0.5f);

// Find closest position.
var otherPositions = someTransforms.Select(t => t.position);
transform.position.GetClosest(otherPositions);
```

### Vector3Int

```csharp
var newVector = someVector3Int.WithX(1);
var newVector = someVector3Int.WithY(1);
var newVector = someVector3Int.WithZ(1);
```

### Vector4

```csharp
var newVector = someVector4.WithX(0.5f);
var newVector = someVector4.WithY(0.5f);
var newVector = someVector4.WithZ(0.5f);
var newVector = someVector4.WithW(0.5f);
```
