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

### GameObject

```csharp
gameObject.GetOrAddComponent<MyComponent>();
```

### Rigidbody

```csharp
// Change direction of movement without modifying speed.
rigidbody.ChangeDirection(Vector3.right);
```

### Transform

```csharp
// Set children of this transform to position (0, 0, 0).
transform.ResetChildPositions();
```

```csharp
transform.SetChildLayers("Ignore Raycast");
```

### Vector3

```csharp
// Find closest position.
var otherPositions = someTransforms.Select(t => t.position);
transform.position.GetClosest(otherPositions);
```
