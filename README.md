# MonoGeometry

MonoGeometry is a simple, low impact primitive drawing add-on for the [Monogame](https://monogame.net/) game engine. It provides a collection of options for drawing simple shapes to the screen, which is a feature that's a bit verbose to achieve normally.

It also provides structures for handling simple 2D shapes that aren't present in Monogame by default, like triangles and circles.

In the future, this project will be expanded with more shape structures, and more options for drawing simple primitives.

# Installation

MonoGeometry can be installed throught the [NuGet](https://www.nuget.org/) package manager, with the following command:
```bash
dotnet add package MonoGeometry --version 1.0.1
```
This package's NuGet page is available [here](https://www.nuget.org/packages/MonoGeometry).
# Usage

The basis of MonoGeometry is the PrimitiveBatch class. Its usage is much the same as the SpriteBatch class provided by default.

Create a private PrimitiveBatch instance, and initialize it in the LoadContent method:
```csharp
private PrimitiveBatch _primitiveBatch;

protected override void LoadContent()
{
  this.Content.RootDirectory = "Content";
  this._primitiveBatch = new(this.GraphicsDevice);
}
```
Primitives can now be drawn to the screen in the Draw method, with the same begin and end syntax as SpriteBatch:
```csharp
protected override void Draw(GameTime gameTime)
{
  this._primitiveBatch.Begin();
  this._primitiveBatch.FillColor = Color.Black;
  //Draw a circle with center coordinates (100, 100) and a radius of 5
  this._primitiveBatch.Circle(new Vector2(100, 100), 5);
  this._primitiveBatch.End();
  base.Draw(gameTime);
}
```

# Contribution

All contributions are welcomed. Please use the provided .editorconfig file for style guidlines.
