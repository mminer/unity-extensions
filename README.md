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

someComponent.GetOrAddComponent<MyComponent>();

someComponent.HasComponent<MyComponent>();
```

### GameObject

```csharp
gameObject.GetOrAddComponent<MyComponent>();

gameObject.HasComponent<MyComponent>();
```

### Rigidbody

```csharp
// Change direction of movement without modifying speed.
rigidbody.ChangeDirection(Vector3.right);
```

### Transform

```csharp
// Make game objects children of this transform.
transform.AddChildren(gameObject1, gameObject2);

// Set children of this transform to position (0, 0, 0).
transform.ResetChildPositions();

transform.SetChildLayers("Ignore Raycast");
```

### Vector3

```csharp
// Find closest position.
var otherPositions = someTransforms.Select(t => t.position);
transform.position.GetClosest(otherPositions);
```


### Vector3Int

```csharp
// Convert `Vector3Int` struct to `Vector3`.
var vector = new Vector3Int(1, 2, 3);
var vector3 = vector.ToVector3();
```
