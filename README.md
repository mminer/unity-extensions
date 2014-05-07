# Unity Extensions

Here we have [extension methods](http://en.wikipedia.org/wiki/Extension_method)
for Unity objects (`GameObject`, `Vector3`, etc.). These add useful
functionality that I often end up reimplementing in every game I make.


## Usage

Add the scripts to your Unity project wherever you see fit. The classes are
in the `Extensions` namespace, so you must first import them with the `using`
keyword.

```csharp
using Extensions;
```

Now call the extensions on the appropriate object type.

```csharp
void Awake ()
{
    var someComponent = gameObject.GetOrAddComponent<MyComponent>();
}
```


## Included Extensions

The extensions here are a work in progress.

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

### NetworkPlayer

```csharp
Network.player.GetIndex();
```

### Rigidbody

```csharp
// Change direction of movement without modifying speed.
rigidbody.ChangeDirection(Vector3.right);
```

### Transform

```csharp
// Make array of game objects children of this transform.
transform.AddChildren(someGameObjects);

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
