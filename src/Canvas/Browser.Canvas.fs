namespace Browser.Types

open Fable.Core
open Fable.Core.JS

/// <summary>
/// Represents the settings for a CanvasRenderingContext2D.
/// </summary>
type CanvasRenderingContext2DSettings =
    /// <summary>
    /// Gets a Boolean indicating if the canvas contains an alpha channel.
    /// </summary>
    /// <remarks>
    /// If false, the backdrop is always opaque, which can speed up drawing of transparent content and images.
    /// </remarks>
    abstract alpha: bool option with get, set

    /// <summary>
    /// Gets the color space of the rendering context.
    /// </summary>
    /// <remarks>
    /// Possible values are "srgb" (denotes the sRGB color space) and "display-p3" (denotes the display-p3 color space).
    /// </remarks>
    abstract colorSpace: string option with get, set

    /// <summary>
    /// Gets a Boolean indicating if the user agent reduced the latency by desynchronizing the canvas paint cycle from the event loop.
    /// </summary>
    abstract desynchronized: bool option with get, set

    /// <summary>
    /// Gets a Boolean indicating whether or not this canvas uses software acceleration (instead of hardware acceleration) to support frequent read-back operations via getImageData().
    /// </summary>
    abstract willReadFrequently: bool option with get, set

type [<StringEnum; RequireQualifiedAccess>] LineCap =
    /// <summary>
    /// The ends of lines are squared off at the endpoints. Default value.
    /// </summary>
    | Butt

    /// <summary>
    /// The ends of lines are rounded.
    /// </summary>
    | Round

    /// <summary>
    /// The ends of lines are squared off by adding a box with an equal width and half the height of the line's thickness.
    /// </summary>
    | Square

type [<StringEnum; RequireQualifiedAccess>] LineJoin =
    /// <summary>
    /// Rounds off the corners of a shape by filling an additional sector of disc centered at the common endpoint of connected segments.
    /// </summary>
    /// <remarks>
    /// The radius for these rounded corners is equal to the line width.
    /// </remarks>
    | Round

    /// <summary>
    /// Fills an additional triangular area between the common endpoint of connected segments and the separate outside rectangular corners of each segment.
    /// </summary>
    | Bevel

    /// <summary>
    /// Connected segments are joined by extending their outside edges to connect at a single point, with the effect of filling an additional lozenge-shaped area.
    /// </summary>
    /// <remarks>
    /// This setting is affected by the miterLimit property. Default value.
    /// </remarks>
    | Miter

type [<StringEnum; RequireQualifiedAccess>] TextAlign =
    /// <summary>
    /// The text is left-aligned.
    /// </summary>
    | Left

    /// <summary>
    /// The text is right-aligned.
    /// </summary>
    | Right

    /// <summary>
    /// The text is centered.
    /// </summary>
    | Center

    /// <summary>
    /// The text is aligned at the normal start of the line (left-aligned for left-to-right locales, right-aligned for right-to-left locales).
    /// </summary>
    | Start

    /// <summary>
    /// The text is aligned at the normal end of the line (right-aligned for left-to-right locales, left-aligned for right-to-left locales).
    /// </summary>
    | End

type [<StringEnum; RequireQualifiedAccess>] TextBaseline =
    /// <summary>
    /// The text baseline is the top of the em square.
    /// </summary>
    | Top

    /// <summary>
    /// The text baseline is the hanging baseline.
    /// </summary>
    /// <remarks>
    /// Used by Tibetan and other Indic scripts.
    /// </remarks>
    | Hanging

    /// <summary>
    /// The text baseline is the middle of the em square.
    /// </summary>
    | Middle

    /// <summary>
    /// The text baseline is the normal alphabetic baseline.
    /// </summary>
    /// <remarks>
    /// Default value.
    /// </remarks>
    | Alphabetic

    /// <summary>
    /// The text baseline is the ideographic baseline; this is the bottom of the body of the characters, if the main body of characters protrudes beneath the alphabetic baseline.
    /// </summary>
    /// <remarks>
    /// Used by Chinese, Japanese, and Korean scripts.
    /// </remarks>
    | Ideographic

    /// <summary>
    /// The text baseline is the bottom of the bounding box.
    /// </summary>
    /// <remarks>
    /// This differs from the ideographic baseline in that the ideographic baseline doesn't consider descenders.
    /// </remarks>
    | Bottom

type [<StringEnum; RequireQualifiedAccess>] TextDirection =
    /// <summary>
    /// The text direction is left-to-right.
    /// </summary>
    | Ltr

    /// <summary>
    /// The text direction is right-to-left.
    /// </summary>
    | Rtl

    /// <summary>
    /// The text direction is inherited from the canvas element or the Document as appropriate. Default value.
    /// </summary>
    | Inherit

type [<StringEnum; RequireQualifiedAccess>] FontKerning =
    /// <summary>
    /// The browser determines whether font kerning should be used or not.
    /// </summary>
    /// <remarks>
    /// For example, some browsers will disable kerning on small fonts, since applying it could harm the readability of text.
    /// </remarks>
    | Auto

    /// <summary>
    /// Font kerning information stored in the font must be applied.
    /// </summary>
    | Normal

    /// <summary>
    /// Font kerning information stored in the font is disabled.
    /// </summary>
    | None

type [<StringEnum; RequireQualifiedAccess>] TextRendering =
    /// <summary>
    /// The browser makes educated guesses about when to optimize for speed, legibility, and geometric precision while drawing text.
    /// </summary>
    | Auto

    /// <summary>
    /// The browser emphasizes rendering speed over legibility and geometric precision when drawing text.
    /// </summary>
    /// <remarks>
    /// This disables kerning and ligatures.
    /// </remarks>
    | OptimizeSpeed

    /// <summary>
    /// The browser emphasizes legibility over rendering speed and geometric precision.
    /// </summary>
    /// <remarks>
    /// This enables kerning and optional ligatures.
    /// </remarks>
    | OptimizeLegibility

    /// <summary>
    /// The browser emphasizes geometric precision over rendering speed and legibility.
    /// </summary>
    /// <remarks>
    /// Certain aspects of fonts, such as kerning, don't scale linearly. For large scale factors, you might see less-than-beautiful text rendering, but the size is what you would expect (neither rounded up nor down to the nearest font size supported by the underlying operating system).
    /// </remarks>
    | GeometricPrecision

/// <summary>
/// Represents the fill rule options for CanvasRenderingContext2D.
/// </summary>
type [<StringEnum; RequireQualifiedAccess>] FillRule =
    /// <summary>
    /// The non-zero winding rule.
    /// </summary>
    /// <remarks>
    /// Default rule.
    /// </remarks>
    | Nonzero

    /// <summary>
    /// The even-odd winding rule.
    /// </summary>
    | Evenodd

type [<StringEnum(CaseRules.KebabCase); RequireQualifiedAccess>] GlobalCompositeOperation =
    /// <summary>
    /// Draws new shapes on top of the existing canvas content (default).
    /// </summary>
    | SourceOver

    /// <summary>
    /// Draws the new shape where it overlaps with the existing content, making everything else transparent.
    /// </summary>
    | SourceIn

    /// <summary>
    /// Draws the new shape where it doesn't overlap with the existing content.
    /// </summary>
    | SourceOut

    /// <summary>
    /// Draws the new shape only where it overlaps the existing content.
    /// </summary>
    | SourceAtop

    /// <summary>
    /// Draws new shapes behind the existing canvas content.
    /// </summary>
    | DestinationOver

    /// <summary>
    /// Keeps the existing canvas content where it overlaps with the new shape, making everything else transparent.
    /// </summary>
    | DestinationIn

    /// <summary>
    /// Keeps the existing content where it doesn't overlap with the new shape.
    /// </summary>
    | DestinationOut

    /// <summary>
    /// The existing canvas is only kept where it overlaps the new shape. The new shape is drawn behind the canvas content.
    /// </summary>
    | DestinationAtop

    /// <summary>
    /// Keeps the existing canvas where it overlaps with the new shape, drawing the new shape behind the canvas content.
    /// </summary>
    | Lighter

    /// <summary>
    /// Determines color values by adding where shapes overlap.
    /// </summary>
    | Copy

    /// <summary>
    /// Makes shapes transparent where they overlap and draws normally everywhere else.
    /// </summary>
    | Xor

    /// <summary>
    /// Multiplies pixels of the top layer with the bottom layer, resulting in a darker image.
    /// </summary>
    | Multiply

    /// <summary>
    /// Inverts, multiplies, and inverts again, producing a lighter image (opposite of multiply).
    /// </summary>
    | Screen

    /// <summary>
    /// Combines multiply and screen, making dark parts darker and light parts lighter.
    /// </summary>
    | Overlay

    /// <summary>
    /// Retains the darkest pixels of both layers.
    /// </summary>
    | Darken

    /// <summary>
    /// Retains the lightest pixels of both layers.
    /// </summary>
    | Lighten

    /// <summary>
    /// Divides the bottom layer by the inverted top layer.
    /// </summary>
    | ColorDodge

    /// <summary>
    /// Divides the inverted bottom layer by the top layer and then inverts the
    /// result.
    /// </summary>
    | ColorBurn

    /// <summary>
    /// Like overlay, a combination of multiply and screen — but instead with the top layer and bottom layer swapped.
    /// </summary>
    | HardLight

    /// <summary>
    /// A softer version of hard-light, preserving color information.
    /// </summary>
    | SoftLight

    /// <summary>
    /// Subtracts one layer from the other, always resulting in a positive value.
    /// </summary>
    | Difference

    /// <summary>
    /// Similar to "difference," but with lower contrast.
    /// </summary>
    | Exclusion

    /// <summary>
    /// Preserves luma and chroma of the bottom layer, adopting the hue of the top layer.
    /// </summary>
    | Hue

    /// <summary>
    /// Preserves luma and hue of the bottom layer, adopting the chroma of the top layer.
    /// </summary>
    | Saturation

    /// <summary>
    /// Preserves luma of the bottom layer, adopting the hue and chroma of the top layer.
    /// </summary>
    | Color

    /// <summary>
    /// Preserves hue and chroma of the bottom layer, adopting the luma of the top layer.
    /// </summary>
    | Luminosity

/// <summary>
/// Represents the dimensions of a piece of text in the canvas.
/// </summary>
type TextMetrics =
    /// <summary>
    /// Returns the width of a segment of inline text in CSS pixels.
    /// </summary>
    /// <remarks>
    /// It takes into account the current font of the context.
    /// </remarks>
    abstract member width : float

    /// <summary>
    /// Distance parallel to the baseline from the alignment point given by the CanvasRenderingContext2D.textAlign property to the left side of the bounding rectangle of the given text, in CSS pixels; positive numbers indicating a distance going left from the given alignment point.
    /// </summary>
    abstract member actualBoundingBoxLeft : float

    /// <summary>
    /// Returns the distance from the alignment point given by the CanvasRenderingContext2D.textAlign property to the right side of the bounding rectangle of the given text, in CSS pixels. The distance is measured parallel to the baseline.
    /// </summary>
    abstract member actualBoundingBoxRight : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the top of the highest bounding rectangle of all the fonts used to render the text, in CSS pixels.
    /// </summary>
    abstract member fontBoundingBoxAscent : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the bottom of the bounding rectangle of all the fonts used to render the text, in CSS pixels.
    /// </summary>
    abstract member fontBoundingBoxDescent : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the top of the bounding rectangle used to render the text, in CSS pixels.
    /// </summary>
    abstract member actualBoundingBoxAscent : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the bottom of the bounding rectangle used to render the text, in CSS pixels.
    /// </summary>
    abstract member actualBoundingBoxDescent : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the top of the em square in the line box, in CSS pixels.
    /// </summary>
    abstract member emHeightAscent : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the bottom of the em square in the line box, in CSS pixels.
    /// </summary>
    abstract member emHeightDescent : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the hanging baseline of the line box, in CSS pixels.
    /// </summary>
    abstract member hangingBaseline : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the alphabetic baseline of the line box, in CSS pixels.
    /// </summary>
    abstract member alphabeticBaseline : float

    /// <summary>
    /// Returns the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the ideographic baseline of the line box, in CSS pixels.
    /// </summary>
    abstract member ideographicBaseline : float

type [<StringEnum(CaseRules.KebabCase); RequireQualifiedAccess>] ColorSpace =
    | Srgb
    | DisplayP3

type ImageDataSettings =
    ///Specifies the color space of the image data
    abstract colorSpace: ColorSpace with get, set

/// <summary>
/// Represents an ImageData object used to manipulate image data.
/// </summary>
[<Erase>]
type ImageData() =
    /// <summary>
    /// Creates a new ImageData object with the specified width and height.
    /// </summary>
    /// <param name="width">An unsigned long representing the width of the image.</param>
    /// <param name="height">An unsigned long representing the height of the image.</param>
    /// <param name="settings">An optional object specifying color space. Possible values: "srgb", "display-p3".</param>
    [<Emit("new ImageData($0, $1, $2)")>]
    new (width: int, height: int, ?settings: ImageDataSettings) = ImageData()

    /// <summary>
    /// Creates a new ImageData object from the given data array and width.
    /// </summary>
    /// <param name="dataArray">A Uint8ClampedArray containing pixel data.</param>
    /// <param name="width">An unsigned long representing the width of the image.</param>
    /// <param name="height">An unsigned long representing the height of the image (optional).</param>
    /// <param name="settings">An optional object specifying color space. Possible values: "srgb", "display-p3".</param>
    [<Emit("new ImageData($0, $1, $2, $3)")>]
    new (dataArray: Uint8ClampedArray, width: int, ?height: int, ?settings: ImageDataSettings) = ImageData()

    /// <summary>
    /// Gets a Uint8ClampedArray that contains the pixel data of the ImageData object.
    /// </summary>
    /// <remarks>
    /// The data is stored as a one-dimensional array in the RGBA order, with values between 0 and 255 (inclusive).
    /// </remarks>
    /// <returns>A Uint8ClampedArray containing pixel data.</returns>
    [<Emit("$0.data")>]
    member _.data = jsNative<JS.Uint8ClampedArray>

    /// <summary>
    /// Gets the color space of the image data.
    /// </summary>
    /// <remarks>
    /// This property can have the following values: "srgb" representing the sRGB color space. "display-p3" representing the display-p3 color space.
    /// </remarks>
    [<Emit("$0.colorSpace")>]
    member _.colorSpace = jsNative<ColorSpace>

    /// <summary>
    /// Gets the number of rows in the ImageData object.
    /// </summary>
    [<Emit("$0.height")>]
    member _.height = jsNative<float>

    /// <summary>
    /// Gets the number of pixels per row in the ImageData object.
    /// </summary>
    [<Emit("$0.width")>]
    member _.width = jsNative<float>

/// <summary>
/// Represents the quality options for image smoothing.
/// </summary>
type [<StringEnum; RequireQualifiedAccess>] ImageSmoothingQualityOptions =
    /// <summary>
    /// Low quality.
    /// </summary>
    | Low
    /// <summary>
    /// Medium quality.
    /// </summary>
    | Medium
    /// <summary>
    /// High quality.
    /// </summary>
    | High

type PathContext2D =
    /// <summary>
    /// Attempts to add a straight line from the current point to the start of the current sub-path.
    /// </summary>
    /// <remarks>
    /// If the shape has already been closed or has only one point, this function does nothing. This method doesn't draw anything to the canvas directly. You can render the path using the <see cref="CanvasRenderingContext2D.stroke"/> or <see cref="CanvasRenderingContext2D.fill"/> methods.
    /// </remarks>
    abstract member closePath : unit -> unit

    /// <summary>
    /// Adds a straight line to the current sub-path by connecting the sub-path's last point to the specified (x, y) coordinates.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the line's end point.</param>
    /// <param name="y">The y-axis coordinate of the line's end point.</param>
    abstract member lineTo : x:float * y:float -> unit

    /// <summary>
    /// Begins a new sub-path at the point specified by the given (x, y) coordinates.
    /// </summary>
    /// <param name="x">The x-axis (horizontal) coordinate of the point.</param>
    /// <param name="y">The y-axis (vertical) coordinate of the point.</param>
    abstract member moveTo : x:float * y:float -> unit

    /// <summary>
    /// Adds a cubic Bézier curve to the current sub-path.
    /// </summary>
    /// <remarks>
    /// It requires three points: the first two are control points, and the third one is the end point. The starting point is the latest point in the current path.
    /// </remarks>
    /// <param name="cp1x">The x-axis coordinate of the first control point.</param>
    /// <param name="cp1y">The y-axis coordinate of the first control point.</param>
    /// <param name="cp2x">The x-axis coordinate of the second control point.</param>
    /// <param name="cp2y">The y-axis coordinate of the second control point.</param>
    /// <param name="x">The x-axis coordinate of the end point.</param>
    /// <param name="y">The y-axis coordinate of the end point.</param>
    abstract member bezierCurveTo : cp1x:float * cp1y:float * cp2x:float * cp2y:float * x:float * y:float -> unit

    /// <summary>
    /// Adds a quadratic Bézier curve to the current sub-path.
    /// </summary>
    /// <remarks>
    /// It requires two points: the first one is a control point, and the second one is the end point. The starting point is the latest point in the current path.
    /// </remarks>
    /// <param name="cpx">The x-axis coordinate of the control point.</param>
    /// <param name="cpy">The y-axis coordinate of the control point.</param>
    /// <param name="x">The x-axis coordinate of the end point.</param>
    /// <param name="y">The y-axis coordinate of the end point.</param>
    abstract member quadraticCurveTo : cpx:float * cpy:float * x:float * y:float -> unit

    /// <summary>
    /// Adds a circular arc to the current sub-path.
    /// </summary>
    /// <param name="x">The horizontal coordinate of the arc's center.</param>
    /// <param name="y">The vertical coordinate of the arc's center.</param>
    /// <param name="radius">The arc's radius. Must be positive.</param>
    /// <param name="startAngle">The angle at which the arc starts in radians, measured from the positive x-axis.</param>
    /// <param name="endAngle">The angle at which the arc ends in radians, measured from the positive x-axis.</param>
    /// <param name="counterclockwise">An optional boolean value. If true, draws the arc counter-clockwise between the start and end angles. The default is false (clockwise).</param>
    abstract member arc : x:float * y:float * radius:float * startAngle:float * endAngle:float * ?counterclockwise:bool -> unit

    /// <summary>
    /// Adds a circular arc to the current sub-path using the given control points and radius.
    /// </summary>
    /// <param name="x1">The x-axis coordinate of the first control point.</param>
    /// <param name="y1">The y-axis coordinate of the first control point.</param>
    /// <param name="x2">The x-axis coordinate of the second control point.</param>
    /// <param name="y2">The y-axis coordinate of the second control point.</param>
    /// <param name="radius">The arc's radius. Must be non-negative.</param>
    abstract member arcTo : x1:float * y1:float * x2:float * y2:float * radius:float -> unit

    /// <summary>
    /// Adds an elliptical arc to the current sub-path.
    /// </summary>
    /// <param name="x">The x-axis (horizontal) coordinate of the ellipse's center.</param>
    /// <param name="y">The y-axis (vertical) coordinate of the ellipse's center.</param>
    /// <param name="radiusX">The ellipse's major-axis radius. Must be non-negative.</param>
    /// <param name="radiusY">The ellipse's minor-axis radius. Must be non-negative.</param>
    /// <param name="rotation">The rotation of the ellipse, expressed in radians.</param>
    /// <param name="startAngle">The eccentric angle at which the ellipse starts, measured clockwise from the positive x-axis and expressed in radians.</param>
    /// <param name="endAngle">The eccentric angle at which the ellipse ends, measured clockwise from the positive x-axis and expressed in radians.</param>
    /// <param name="counterclockwise">An optional boolean value. If true, draws the ellipse counterclockwise (anticlockwise). The default value is false (clockwise).</param>
    abstract member ellipse : x:float * y:float * radiusX:float * radiusY:float * rotation:float * startAngle:float * endAngle:float* ?counterclockwise:bool -> unit

    /// <summary>
    /// Adds a rectangle to the current path.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the rectangle's starting point.</param>
    /// <param name="y">The y-axis coordinate of the rectangle's starting point.</param>
    /// <param name="width">The rectangle's width. Positive values are to the right, and negative values are to the left.</param>
    /// <param name="height">The rectangle's height. Positive values are down, and negative values are up.</param>
    abstract member rect : x:float * y:float * width:float * height:float -> unit

    /// <summary>
    /// Adds a rounded rectangle to the current path.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the rectangle's starting point, in pixels.</param>
    /// <param name="y">The y-axis coordinate of the rectangle's starting point, in pixels.</param>
    /// <param name="width">The rectangle's width. Positive values are to the right, and negative values are to the left.</param>
    /// <param name="height">The rectangle's height. Positive values are down, and negative values are up.</param>
    /// <param name="radii">A number, list, DOMPoint, DOMPointReadOnly instance, or an object specifying the radii of the circular arc to be used for the corners of the rectangle. The number and order of the radii function similarly to the border-radius CSS property when width and height are positive: - [all-corners] - [top-left-and-bottom-right, top-right-and-bottom-left] - [top-left, top-right-and-bottom-left, bottom-right] - [top-left, top-right, bottom-right, bottom-left] If width is negative, the rounded rectangle is flipped horizontally, and the radius values are adjusted accordingly. Similarly, when height is negative, the rounded rectangle is flipped vertically. The specified radii may be scaled if any of the edges are shorter than the combined radius of the vertices on either end.</param>
    abstract member roundRect : x:float * y:float * width:float * height:float * radii:float -> unit

    /// <summary>
    /// Adds a rounded rectangle to the current path.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the rectangle's starting point, in pixels.</param>
    /// <param name="y">The y-axis coordinate of the rectangle's starting point, in pixels.</param>
    /// <param name="width">The rectangle's width. Positive values are to the right, and negative values are to the left.</param>
    /// <param name="height">The rectangle's height. Positive values are down, and negative values are up.</param>
    /// <param name="radii">A number, list, DOMPoint, DOMPointReadOnly instance, or an object specifying the radii of the circular arc to be used for the corners of the rectangle. The number and order of the radii function similarly to the border-radius CSS property when width and height are positive: - [all-corners] - [top-left-and-bottom-right, top-right-and-bottom-left] - [top-left, top-right-and-bottom-left, bottom-right] - [top-left, top-right, bottom-right, bottom-left] If width is negative, the rounded rectangle is flipped horizontally, and the radius values are adjusted accordingly. Similarly, when height is negative, the rounded rectangle is flipped vertically. The specified radii may be scaled if any of the edges are shorter than the combined radius of the vertices on either end.</param>
    abstract member roundRect : x:float * y:float * width:float * height:float * radii:float array -> unit

    /// <summary>
    /// Adds a rounded rectangle to the current path.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the rectangle's starting point, in pixels.</param>
    /// <param name="y">The y-axis coordinate of the rectangle's starting point, in pixels.</param>
    /// <param name="width">The rectangle's width. Positive values are to the right, and negative values are to the left.</param>
    /// <param name="height">The rectangle's height. Positive values are down, and negative values are up.</param>
    /// <param name="radii">A number, list, DOMPoint, DOMPointReadOnly instance, or an object specifying the radii of the circular arc to be used for the corners of the rectangle. The number and order of the radii function similarly to the border-radius CSS property when width and height are positive: - [all-corners] - [top-left-and-bottom-right, top-right-and-bottom-left] - [top-left, top-right-and-bottom-left, bottom-right] - [top-left, top-right, bottom-right, bottom-left] If width is negative, the rounded rectangle is flipped horizontally, and the radius values are adjusted accordingly. Similarly, when height is negative, the rounded rectangle is flipped vertically. The specified radii may be scaled if any of the edges are shorter than the combined radius of the vertices on either end.</param>
    abstract member roundRect : x:float * y:float * width:float * height:float * radii:obj -> unit

/// The Path2D interface of the Canvas 2D API is used to declare a path that can then be used on a CanvasRenderingContext2D object
type Path2D =
    inherit PathContext2D

    /// <summary>
    /// Adds one Path2D object to another Path2D object.
    /// </summary>
    /// <param name="path">A Path2D path to add.</param>
    /// <param name="transform">An optional DOMMatrix to be used as the transformation matrix for the path that is added.</param>
    abstract addPath : path: Path2D * ?transform: obj -> unit

type Path2DStatic =
    /// <summary>
    /// Creates a new empty Path2D object.
    /// </summary>
    [<EmitConstructor>]
    abstract Create: unit -> Path2D

    /// <summary>
    /// Creates a new Path2D object as a copy of the provided path.
    /// </summary>
    /// <param name="path">The Path2D object to copy.</param>
    [<EmitConstructor>]
    abstract Create: path: Path2D -> Path2D

    /// <summary>
    /// Creates a new Path2D object from the specified SVG path data.
    /// </summary>
    /// <param name="d">A string containing SVG path data.</param>
    [<EmitConstructor>]
    abstract Create: d: string -> Path2D

/// The CanvasGradient interface represents an opaque object describing a gradient
type CanvasGradient =
    /// <summary>
    /// Adds a new color stop to the gradient, defined by an offset and a color.
    /// </summary>
    /// <param name="offset">A number between 0 and 1, inclusive, representing the position of the color stop. 0 represents the start of the gradient, and 1 represents the end.</param>
    /// <param name="color">A CSS &lt;color&gt; value representing the color of the stop.</param>
    abstract member addColorStop : offset:float * color:string -> unit

/// The CanvasPattern interface represents an opaque object describing a pattern, based on an image, a canvas, or a video
type CanvasPattern =
    /// <summary>
    /// Uses a DOMMatrix object as the pattern's transformation matrix and invokes it on the pattern.
    /// </summary>
    /// <param name="matrix">A DOMMatrix to use as the pattern's transformation matrix.</param>
    abstract member setTransform : matrix:obj -> unit

type [<Erase>] PaintStyle =
    /// <summary>
    /// A string parsed as a CSS &lt;color&gt; value.
    /// </summary>
    | Color of string

    /// <summary>
    /// A CanvasGradient object (a linear or radial gradient).
    /// </summary>
    | Gradient of CanvasGradient

    /// <summary>
    /// A CanvasPattern object (a repeating image).
    /// </summary>
    | Pattern of CanvasPattern

/// <summary>
/// Represents the repetition options for creating a pattern.
/// </summary>
type [<StringEnum(CaseRules.KebabCase)>] Repetition =
    /// <summary>
    /// Repeat the pattern in both horizontal and vertical directions.
    /// </summary>
    | Repeat

    /// <summary>
    /// Repeat the pattern only in the horizontal direction.
    /// </summary>
    | RepeatX

    /// <summary>
    /// Repeat the pattern only in the vertical direction.
    /// </summary>
    | RepeatY

    /// <summary>
    /// Do not repeat the pattern in either direction.
    /// </summary>
    | NoRepeat

type TransformMatrix =
    abstract a: float with get, set
    abstract b: float with get, set
    abstract c: float with get, set
    abstract d: float with get, set
    abstract e: float with get, set
    abstract f: float with get, set

type CanvasRenderingContext2D =
    inherit PathContext2D

    /// <summary>
    /// Sets the pixels in a rectangular area to transparent black (rgba(0,0,0,0)).
    /// </summary>
    /// <param name="x">The x-axis coordinate of the rectangle's top-left corner.</param>
    /// <param name="y">The y-axis coordinate of the rectangle's top-left corner.</param>
    /// <param name="width">The width of the rectangle. Positive values move to the right, and negative values to the left.</param>
    /// <param name="height">The height of the rectangle. Positive values move down, and negative values move up.</param>
    abstract member clearRect : x:float * y:float * width:float * height:float -> unit

    /// <summary>
    /// Draws a filled rectangle on the canvas.
    /// </summary>
    /// <remarks>
    /// The rectangle's fill style is determined by the current fillStyle attribute. This method draws directly to the canvas without modifying the current path, so any subsequent fill() or stroke() calls will have no effect on it.
    /// </remarks>
    /// <param name="x">The x-axis coordinate of the rectangle's starting point.</param>
    /// <param name="y">The y-axis coordinate of the rectangle's starting point.</param>
    /// <param name="width">The width of the rectangle. Positive values move to the right, and negative values to the left.</param>
    /// <param name="height">The height of the rectangle. Positive values move down, and negative values move up.</param>
    abstract member fillRect : x:float * y:float * width:float * height:float -> unit

    /// <summary>
    /// Draws a stroked rectangle on the canvas.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the rectangle's starting point.</param>
    /// <param name="y">The y-axis coordinate of the rectangle's starting point.</param>
    /// <param name="width">The width of the rectangle. Positive values move to the right, and negative values to the left.</param>
    /// <param name="height">The height of the rectangle. Positive values move down, and negative values move up.</param>
    abstract member strokeRect : x:float * y:float * width:float * height:float -> unit

    /// <summary>
    /// Draws a text string at the specified coordinates, filling the string's characters with the current fillStyle.
    /// </summary>
    /// <param name="text">A string specifying the text string to render into the context.</param>
    /// <param name="x">The x-axis coordinate of the point at which to begin drawing the text, in pixels.</param>
    /// <param name="y">The y-axis coordinate of the baseline on which to begin drawing the text, in pixels.</param>
    /// <param name="maxWidth">Optional. The maximum number of pixels wide the text may be once rendered. If not specified, there is no limit to the width of the text. However, if this value is provided, the user agent will adjust the kerning, select a more horizontally condensed font (if one is available or can be generated without loss of quality), or scale down to a smaller font size in order to fit the text in the specified width.</param>
    abstract member fillText : text:string * x:float * y:float * ?maxWidth:float -> unit

    /// <summary>
    /// Strokes — that is, draws the outlines of — the characters of a text string at the specified coordinates.
    /// </summary>
    /// <param name="text">A string specifying the text string to render into the context.</param>
    /// <param name="x">The x-axis coordinate of the point at which to begin drawing the text.</param>
    /// <param name="y">The y-axis coordinate of the point at which to begin drawing the text.</param>
    /// <param name="maxWidth">Optional. The maximum width the text may be once rendered. If not specified, there is no limit to the width of the text. However, if this value is provided, the user agent will adjust the kerning, select a more horizontally condensed font (if one is available or can be generated without loss of quality), or scale down to a smaller font size in order to fit the text in the specified width.</param>
    abstract member strokeText : text:string * x:float * y:float * ?maxWidth:float -> unit

    /// <summary>
    /// Returns a TextMetrics object that contains information about the measured text, such as its width.
    /// </summary>
    /// <param name="text">The text string to measure.</param>
    /// <returns>A TextMetrics object.</returns>
    abstract member measureText : text:string -> TextMetrics

    /// <summary>
    /// Gets or sets the thickness of lines.
    /// </summary>
    /// <value>
    /// A number specifying the line width, in coordinate space units. Zero, negative, Infinity, and NaN values are ignored. The default value is 1.0.
    /// </value>
    abstract member lineWidth : float with get, set

    /// <summary>
    /// Gets or sets the shape used to draw the end points of lines.
    /// </summary>
    abstract member lineCap : LineCap with get, set

    /// <summary>
    /// Gets or sets the shape used to join two line segments where they meet.
    /// </summary>
    abstract member lineJoin : LineJoin with get, set

    /// <summary>
    /// Gets or sets the miter limit ratio.
    /// </summary>
    /// <value>
    /// A number specifying the miter limit ratio, in coordinate space units. Zero, negative, Infinity, and NaN values are ignored. The default value is 10.0.
    /// </value>
    abstract member miterLimit : float with get, set

    /// <summary>
    /// Gets the current line dash pattern.
    /// </summary>
    /// <returns>
    /// An array of numbers that specify distances to alternately draw a line and a gap (in coordinate space units). If the number, when setting the elements, is odd, the elements of the array get copied and concatenated. For example, setting the line dash to [5, 15, 25] will result in getting back [5, 15, 25, 5, 15, 25].
    /// </returns>
    abstract member getLineDash : unit -> float[]

    /// <summary>
    /// Sets the line dash pattern used when stroking lines.
    /// </summary>
    /// <param name="segments">An array of numbers that specify distances to alternately draw a line and a gap (in coordinate space units). If the number of elements in the array is odd, the elements of the array get copied and concatenated. For example, [5, 15, 25] will become [5, 15, 25, 5, 15, 25]. If the array is empty, the line dash list is cleared, and line strokes return to being solid.</param>
    abstract member setLineDash : segments:float[] -> unit

    /// <summary>
    /// Gets or sets the line dash offset, or "phase."
    /// </summary>
    /// <value>
    /// A float specifying the amount of the line dash offset. The default value is 0.0.
    /// </value>
    abstract member lineDashOffset : float with get, set

    /// <summary>
    /// Gets or sets the current text style to use when drawing text.
    /// </summary>
    /// <value>
    /// A string parsed as a CSS font value. The default font is "10px sans-serif."
    /// </value>
    abstract member font : string with get, set

    /// <summary>
    /// Gets or sets the current text alignment used when drawing text.
    /// </summary>
    /// <value>
    /// The default value is <see cref="TextAlign.Start"/>.
    /// </value>
    abstract member textAlign : TextAlign with get, set

    /// <summary>
    /// Gets or sets the current text baseline used when drawing text.
    /// </summary>
    /// <value>
    /// The default value is <see cref="TextBaseline.Alphabetic"/>.
    /// </value>
    abstract member textBaseline : TextBaseline with get, set

    /// <summary>
    /// Gets or sets the spacing between letters when drawing text.
    /// </summary>
    /// <value>
    /// The letter spacing as a string in the CSS length data format. The default is "0px." The property value will remain unchanged if set to an invalid/unparsable value.
    /// </value>
    abstract member letterSpacing : string with get, set

    /// <summary>
    /// Gets or sets how font kerning information is used.
    /// </summary>
    abstract member fontKerning : FontKerning with get, set

    /// <summary>
    /// Gets or sets information to the rendering engine about what to optimize for when rendering text.
    /// </summary>
    abstract member textRendering : TextRendering with get, set

    /// <summary>
    /// Gets or sets the spacing between words when drawing text.
    /// </summary>
    /// <value>
    /// The word spacing as a string in the CSS length data format. The default is "0px." The property can be used to get or set the spacing, and the property value will remain unchanged if set to an invalid/unparsable value.
    /// </value>
    abstract member wordSpacing : string with get, set

    /// <summary>
    /// Gets or sets the color, gradient, or pattern to use inside shapes.
    /// </summary>
    abstract member fillStyle : PaintStyle with get, set

    /// <summary>
    /// Gets or sets the color, gradient, or pattern to use for the strokes (outlines) around shapes.
    /// </summary>
    abstract member strokeStyle : PaintStyle with get, set

    /// <summary>
    /// Creates a conic gradient around a point with given coordinates.
    /// </summary>
    /// <param name="startAngle">The angle at which to begin the gradient, in radians. The angle starts from a line going horizontally right from the center, and proceeds clockwise.</param>
    /// <param name="x">The x-axis coordinate of the center of the gradient.</param>
    /// <param name="y">The y-axis coordinate of the center of the gradient.</param>
    /// <returns>A conic CanvasGradient.</returns>
    abstract member createConicGradient : startAngle:float * x:float * y:float -> CanvasGradient

    /// <summary>
    /// Creates a gradient along the line connecting two given coordinates.
    /// </summary>
    /// <param name="x0">The x-axis coordinate of the start point.</param>
    /// <param name="y0">The y-axis coordinate of the start point.</param>
    /// <param name="x1">The x-axis coordinate of the end point.</param>
    /// <param name="y1">The y-axis coordinate of the end point.</param>
    /// <returns>A linear CanvasGradient initialized with the specified line.</returns>
    /// <exception ref="Exception">NotSupportedError - Thrown when non-finite values are passed as parameters.</exception>
    abstract member createLinearGradient : x0:float * y0:float * x1:float * y1:float -> CanvasGradient

    /// <summary>
    /// Creates a radial gradient using the size and coordinates of two circles.
    /// </summary>
    /// <param name="x0">The x-axis coordinate of the start circle.</param>
    /// <param name="y0">The y-axis coordinate of the start circle.</param>
    /// <param name="r0">The radius of the start circle. Must be non-negative and finite.</param>
    /// <param name="x1">The x-axis coordinate of the end circle.</param>
    /// <param name="y1">The y-axis coordinate of the end circle.</param>
    /// <param name="r1">The radius of the end circle. Must be non-negative and finite.</param>
    /// <returns>A radial CanvasGradient initialized with the two specified circles.</returns>
    /// <exception cref="Exception">NotSupportedError - Thrown when non-finite values are passed as parameters.</exception>
    /// <exception cref="Exception">IndexSizeError - Thrown when a negative radius is passed as a parameter.</exception>
    abstract member createRadialGradient : x0:float * y0:float * r0:float * x1:float * y1:float * r1:float -> CanvasGradient

    /// <summary>
    /// Creates a pattern using the specified image and repetition.
    /// </summary>
    /// <param name="image">An image to be used as the pattern's image. It can be any of the following: - HTMLImageElement (img) - SVGImageElement (image) - HTMLVideoElement (video, by using the capture of the video) - HTMLCanvasElement (canvas) - ImageBitmap - OffscreenCanvas - VideoFrame</param>
    /// <param name="repetition">A string indicating how to repeat the pattern's image. If repetition is specified as an empty string ("") or null (but not undefined), a value of "repeat" will be used.</param>
    /// <returns>
    /// A CanvasPattern object describing a pattern. If the image is not fully loaded (HTMLImageElement.complete is false), then null is returned.
    /// </returns>
    abstract member createPattern : image:obj * repetition:Repetition -> CanvasPattern

    /// <summary>
    /// Specifies the amount of blur applied to shadows.
    /// </summary>
    /// <remarks>
    /// <para>Shadows are only drawn if the <see cref="CanvasRenderingContext2D.shadowColor"/> property is set to a non-transparent value.</para>
    /// <para>At least one of the <see cref="CanvasRenderingContext2D.shadowBlur"/>, <see cref="CanvasRenderingContext2D.shadowOffsetX"/>, or <see cref="CanvasRenderingContext2D.shadowOffsetY"/> properties must be non-zero to render shadows.</para>
    /// </remarks>
    /// <value>
    /// A non-negative float specifying the level of shadow blur, where 0 represents no blur, and larger numbers represent increasingly more blur. This value doesn't correspond to a number of pixels and is not affected by the current transformation matrix. The default value is 0. Negative, Infinity, and NaN values are ignored.
    /// </value>
    abstract member shadowBlur : float with get, set

    /// <summary>
    /// Specifies the color of shadows.
    /// </summary>
    /// <remarks>
    /// <para>Be aware that the shadow's rendered opacity will be affected by the opacity of the <see cref="CanvasRenderingContext2D.fillStyle"/> color when filling, and of the <see cref="CanvasRenderingContext2D.strokeStyle"/> color when stroking.</para>
    /// <para>Shadows are only drawn if the <see cref="CanvasRenderingContext2D.shadowColor"/> property is set to a non-transparent value.</para>
    /// <para>At least one of the <see cref="CanvasRenderingContext2D.shadowBlur"/>, <see cref="CanvasRenderingContext2D.shadowOffsetX"/>, or <see cref="CanvasRenderingContext2D.shadowOffsetY"/> properties must be non-zero to render shadows.</para>
    /// </remarks>
    /// <value>
    /// A string parsed as a CSS color value. The default value is fully-transparent black.
    /// </value>
    abstract member shadowColor : string with get, set

    /// <summary>
    /// Specifies the distance that shadows will be offset horizontally.
    /// </summary>
    /// <remarks>
    /// <para>Shadows are only drawn if the <see cref="CanvasRenderingContext2D.shadowColor"/> property is set to a non-transparent value.</para>
    /// <para>At least one of the <see cref="CanvasRenderingContext2D.shadowBlur"/>, <see cref="CanvasRenderingContext2D.shadowOffsetX"/>, or <see cref="CanvasRenderingContext2D.shadowOffsetY"/> properties must be non-zero to render shadows.</para>
    /// </remarks>
    /// <value>
    /// A float specifying the distance that shadows will be offset horizontally. Positive values are to the right, and negative values are to the left. The default value is 0 (no horizontal offset). Infinity and NaN values are ignored.
    /// </value>
    abstract member shadowOffsetX : float with get, set

    /// <summary>
    /// Specifies the distance that shadows will be offset vertically.
    /// </summary>
    /// <remarks>
    /// <para>Shadows are only drawn if the <see cref="CanvasRenderingContext2D.shadowColor"/> property is set to a non-transparent value.</para>
    /// <para>At least one of the <see cref="CanvasRenderingContext2D.shadowBlur"/>, <see cref="CanvasRenderingContext2D.shadowOffsetX"/>, or <see cref="CanvasRenderingContext2D.shadowOffsetY"/> properties must be non-zero to render shadows.</para>
    /// </remarks>
    /// <value>
    /// A float specifying the distance that shadows will be offset vertically. Positive values are down, and negative values are up. The default value is 0 (no vertical offset). Infinity and NaN values are ignored.
    /// </value>
    abstract member shadowOffsetY : float with get, set

    /// <summary>
    /// Starts a new path by emptying the list of sub-paths.
    /// </summary>
    /// <remarks>
    /// Call this method when you want to create a new path. To create a new sub-path, i.e., one matching the current canvas state, you can use <see cref="CanvasRenderingContext2D.moveTo"/>.
    /// </remarks>
    abstract member beginPath : unit -> unit

    /// <summary>
    /// Fills the current or given path with the current fillStyle.
    /// </summary>
    /// <param name="path">An optional Path2D path to fill.</param>
    /// <param name="fillRule">An optional fill rule that determines if a point is inside or outside the filling region. Default rule is "nonzero".</param>
    abstract member fill : ?path: Path2D * ?fillRule: FillRule -> unit

    /// <summary>
    /// Strokes (outlines) the current or given path with the current stroke style.
    /// </summary>
    /// <remarks>
    /// Strokes are aligned to the center of a path; half of the stroke is drawn on the inner side, and half on the outer side. The stroke is drawn using the non-zero winding rule, meaning that path intersections will still get filled.
    /// </remarks>
    /// <param name="path">A Path2D path to stroke. If not specified, the current path is stroked.</param>
    abstract stroke : ?path:Path2D -> unit

    /// <summary>
    /// Draws a focus ring around the current or given path if the specified element is focused.
    /// </summary>
    /// <param name="element">The element to check whether it is focused or not.</param>
    /// <returns>None (undefined).</returns>
    abstract drawFocusIfNeeded : element:Element -> unit

    /// <summary>
    /// Draws a focus ring around the specified path if the specified element is focused.
    /// </summary>
    /// <param name="path">A Path2D path to use.</param>
    /// <param name="element">The element to check whether it is focused or not.</param>
    /// <returns>None (undefined).</returns>
    abstract drawFocusIfNeeded : path:Path2D * element:Element -> unit

    /// <summary>
    /// Turns the current path into the current clipping region.
    /// </summary>
    /// <remarks>
    /// The previous clipping region, if any, is intersected with the current path to create the new clipping region.
    /// </remarks>
    abstract member clip : unit -> unit

    /// <summary>
    /// Turns the specified path into the current clipping region.
    /// </summary>
    /// <remarks>
    /// The previous clipping region, if any, is intersected with the specified path to create the new clipping region.
    /// </remarks>
    /// <param name="path">A Path2D path to use as the clipping region.</param>
    abstract member clip : path:Path2D -> unit

    /// <summary>
    /// Turns the current path into the current clipping region with the specified fill rule.
    /// </summary>
    /// <remarks>
    /// The previous clipping region, if any, is intersected with the current path to create the new clipping region.
    /// </remarks>
    /// <param name="fillRule">The algorithm by which to determine if a point is inside or outside the clipping region. Possible values: "nonzero" (default), "evenodd".</param>
    abstract member clip : fillRule:FillRule -> unit

    /// <summary>
    /// Turns the specified path into the current clipping region with the specified fill rule.
    /// </summary>
    /// <remarks>
    /// The previous clipping region, if any, is intersected with the specified path to create the new clipping region.
    /// </remarks>
    /// <param name="path">A Path2D path to use as the clipping region.</param>
    /// <param name="fillRule">The algorithm by which to determine if a point is inside or outside the clipping region. Possible values: "nonzero" (default), "evenodd".</param>
    /// <returns>None (undefined).</returns>
    abstract clip : path:Path2D * fillRule:FillRule -> unit

    /// <summary>
    /// Reports whether or not the specified point is contained in the current path.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <param name="y">The y-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <returns>True if the point is inside the path; false otherwise.</returns>
    abstract isPointInPath : x:float * y:float -> bool

    /// <summary>
    /// Reports whether or not the specified point is contained in the current path with the specified fill rule.
    /// </summary>
    /// <param name="x">The x-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <param name="y">The y-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <param name="fillRule">The algorithm to determine if a point is inside or outside the path (nonzero or evenodd).</param>
    /// <returns>True if the point is inside the path; false otherwise.</returns>
    abstract isPointInPath : x:float * y:float * fillRule:FillRule -> bool

    /// <summary>
    /// Reports whether or not the specified point is contained in the specified path.
    /// </summary>
    /// <param name="path">A Path2D path to check against.</param>
    /// <param name="x">The x-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <param name="y">The y-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <returns>True if the point is inside the path; false otherwise.</returns>
    abstract isPointInPath : path:Path2D * x:float * y:float -> bool

    /// <summary>
    /// Reports whether or not the specified point is contained in the specified path with the specified fill rule.
    /// </summary>
    /// <param name="path">A Path2D path to check against.</param>
    /// <param name="x">The x-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <param name="y">The y-axis coordinate of the point to check, unaffected by the current transformation of the context.</param>
    /// <param name="fillRule">The algorithm to determine if a point is inside or outside the path (nonzero or evenodd).</param>
    /// <returns>True if the point is inside the path; false otherwise.</returns>
    abstract isPointInPath : path:Path2D * x:float * y:float * fillRule:FillRule -> bool

    /// <summary>
    /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
    /// </summary>
    /// <remarks>
    /// If the path is unspecified, the current path is used.
    /// </remarks>
    /// <param name="x">The x-axis coordinate of the point to check.</param>
    /// <param name="y">The y-axis coordinate of the point to check.</param>
    /// <returns>A boolean value indicating whether the point is inside the area contained by the stroking of a path.</returns>
    abstract isPointInStroke : x:float * y:float -> bool

    /// <summary>
    /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
    /// </summary>
    /// <param name="path">A Path2D path to check against.</param>
    /// <param name="x">The x-axis coordinate of the point to check.</param>
    /// <param name="y">The y-axis coordinate of the point to check.</param>
    /// <returns>A boolean value indicating whether the point is inside the area contained by the stroking of the specified path.</returns>
    abstract isPointInStroke : path:Path2D * x:float * y:float -> bool

    /// <summary>
    /// Retrieves the current transformation matrix being applied to the context.
    /// </summary>
    /// <returns>A DOMMatrix object representing the current transformation matrix.</returns>
    abstract getTransform : unit -> obj

    /// <summary>
    /// Adds a rotation to the transformation matrix.
    /// </summary>
    /// <remarks>
    /// The rotation center point is always the canvas origin. To change the center point, you will need to move the canvas by using the translate() method.
    /// </remarks>
    /// <param name="angle">The rotation angle, clockwise in radians. You can use degree * Math.PI / 180 to calculate a radian from a degree.</param>
    abstract rotate : angle:float -> unit

    /// <summary>
    /// Adds a scaling transformation to the canvas units horizontally and/or vertically.
    /// </summary>
    /// <remarks>
    /// By default, one unit on the canvas is exactly one pixel. A scaling transformation modifies this behavior. For example, a scaling factor of 0.5 results in a unit size of 0.5 pixels, making shapes half the normal size. Similarly, a scaling factor of 2.0 increases the unit size so that one unit becomes two pixels, making shapes twice the normal size.
    /// </remarks>
    /// <param name="x">Scaling factor in the horizontal direction. A negative value flips pixels across the vertical axis. A value of 1 results in no horizontal scaling (default).</param>
    /// <param name="y">Scaling factor in the vertical direction. A negative value flips pixels across the horizontal axis. A value of 1 results in no vertical scaling (default).</param>
    abstract scale : x:float * y:float -> unit

    /// <summary>
    /// Adds a translation transformation to the current matrix by moving the canvas and its origin.
    /// </summary>
    /// <param name="x">Distance to move in the horizontal direction. Positive values move to the right, and negative values to the left.</param>
    /// <param name="y">Distance to move in the vertical direction. Positive values move down, and negative values move up.</param>
    abstract translate : x:float * y:float -> unit

    /// <summary>
    /// Multiplies the current transformation with the matrix described by the given values.
    /// </summary>
    /// <remarks>
    /// This allows you to scale, rotate, translate (move), and skew the context.
    /// </remarks>
    /// <param name="a">The cell in the first row and first column of the matrix.</param>
    /// <param name="b">The cell in the second row and first column of the matrix.</param>
    /// <param name="c">The cell in the first row and second column of the matrix.</param>
    /// <param name="d">The cell in the second row and second column of the matrix.</param>
    /// <param name="e">The cell in the first row and third column of the matrix.</param>
    /// <param name="f">The cell in the second row and third column of the matrix.</param>
    abstract transform : a:float * b:float * c:float * d:float * e:float * f:float -> unit

    /// <summary>
    /// Resets the current transformation to the identity matrix and applies a transformation to the context.
    /// </summary>
    /// <remarks>
    /// This lets you scale, rotate, translate (move), and skew the context.
    /// </remarks>
    /// <param name="a">The cell in the first row and first column of the transformation matrix (default: 1.0).</param>
    /// <param name="b">The cell in the second row and first column of the transformation matrix (default: 0.0).</param>
    /// <param name="c">The cell in the first row and second column of the transformation matrix (default: 0.0).</param>
    /// <param name="d">The cell in the second row and second column of the transformation matrix (default: 1.0).</param>
    /// <param name="e">The cell in the first row and third column of the transformation matrix (default: 0.0).</param>
    /// <param name="f">The cell in the second row and third column of the transformation matrix (default: 0.0).</param>
    abstract setTransform : a:float * b:float * c:float * d:float * e:float * f:float -> unit

    /// <summary>
    /// Resets the current transformation to the identity matrix and applies a transformation to the context.
    /// </summary>
    /// <remarks>
    /// This lets you scale, rotate, translate (move), and skew the context.
    /// </remarks>
    /// <param name="matrix">A record representing the transformation matrix. The record should have fields a, b, c, d, e, and f. Omitted fields default to values (a: 1.0, b: 0.0, c: 0.0, d: 1.0, e: 0.0, f: 0.0).</param>
    abstract setTransform : matrix:TransformMatrix -> unit

    /// <summary>
    /// Resets the current transformation matrix to the identity matrix.
    /// </summary>
    abstract resetTransform : unit -> unit

    /// <summary>
    /// Gets or sets the alpha (transparency) value that is applied to shapes and images before they are drawn onto the canvas.
    /// </summary>
    /// <remarks>
    /// A number between 0.0 (fully transparent) and 1.0 (fully opaque), inclusive. Values outside that range, including Infinity and NaN, will not be set, and globalAlpha will retain its previous value. The default value is 1.0.
    /// </remarks>
    /// <value>
    /// The alpha value for global transparency. It is a number between 0.0 and 1.0.
    /// </value>
    abstract globalAlpha : float with get, set

    /// <summary>
    /// Gets or sets the compositing operation to apply when drawing new shapes.
    /// </summary>
    /// <remarks>
    /// This property specifies the compositing or blending mode to use for drawing operations. It determines how new shapes are combined with existing canvas content.
    /// </remarks>
    /// <value>
    /// A string identifying the compositing or blending mode operation</value>
    abstract globalCompositeOperation : GlobalCompositeOperation with get, set

    /// <summary>
    /// Draws an image onto the canvas using various combinations of source and destination coordinates and dimensions.
    /// </summary>
    /// <param name="image">An element to draw into the context. Permitted types include HTMLImageElement, SVGImageElement, HTMLVideoElement, HTMLCanvasElement, ImageBitmap, OffscreenCanvas, or VideoFrame.</param>
    /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
    /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
    /// <exception cref="Exception">InvalidStateError: Thrown when the image has no image data or if the canvas or source rectangle width or height is zero.</exception>
    /// <exception cref="Exception">TypeMismatchError: Thrown when a null or undefined image is passed as a parameter.</exception>
    abstract drawImage : image: obj * dx: float * dy: float -> unit

    /// <summary>
    /// Draws an image onto the canvas using various combinations of source and destination coordinates and dimensions.
    /// </summary>
    /// <param name="image">An element to draw into the context. Permitted types include HTMLImageElement, SVGImageElement, HTMLVideoElement, HTMLCanvasElement, ImageBitmap, OffscreenCanvas, or VideoFrame.</param>
    /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
    /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
    /// <param name="dWidth">The width to draw the image in the destination canvas. Allows scaling of the drawn image. Not specified in the 3-argument syntax.</param>
    /// <param name="dHeight">The height to draw the image in the destination canvas. Allows scaling of the drawn image. Not specified in the 3-argument syntax.</param>
    /// <exception cref="Exception">InvalidStateError: Thrown when the image has no image data or if the canvas or source rectangle width or height is zero.</exception>
    /// <exception cref="Exception">TypeMismatchError: Thrown when a null or undefined image is passed as a parameter.</exception>
    abstract drawImage : image: obj * dx: float * dy: float * dWidth: float option * dHeight: float option -> unit

    /// <summary>
    /// Draws an image onto the canvas using various combinations of source and destination coordinates and dimensions.
    /// </summary>
    /// <param name="image">An element to draw into the context. Permitted types include HTMLImageElement, SVGImageElement, HTMLVideoElement, HTMLCanvasElement, ImageBitmap, OffscreenCanvas, or VideoFrame.</param>
    /// <param name="sx">The x-axis coordinate of the top left corner of the sub-rectangle of the source image to draw into the destination context. Use the 3- or 5-argument syntax to omit this argument.</param>
    /// <param name="sy">The y-axis coordinate of the top left corner of the sub-rectangle of the source image to draw into the destination context. Use the 3- or 5-argument syntax to omit this argument.</param>
    /// <param name="sWidth">The width of the sub-rectangle of the source image to draw into the destination context. Use the 3- or 5-argument syntax to omit this argument. A negative value will flip the image.</param>
    /// <param name="sHeight">The height of the sub-rectangle of the source image to draw into the destination context. Use the 3- or 5-argument syntax to omit this argument. A negative value will flip the image.</param>
    /// <param name="dx">The x-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
    /// <param name="dy">The y-axis coordinate in the destination canvas at which to place the top-left corner of the source image.</param>
    /// <param name="dWidth">The width to draw the image in the destination canvas. Allows scaling of the drawn image. Not specified in the 3-argument syntax.</param>
    /// <param name="dHeight">The height to draw the image in the destination canvas. Allows scaling of the drawn image. Not specified in the 3-argument syntax.</param>
    /// <exception cref="Exception">InvalidStateError: Thrown when the image has no image data or if the canvas or source rectangle width or height is zero.</exception>
    /// <exception cref="Exception">TypeMismatchError: Thrown when a null or undefined image is passed as a parameter.</exception>
    abstract drawImage : image: obj * sx: float * sy: float * sWidth: float option * sHeight: float option * dx: float option * dy: float option * dWidth: float option * dHeight: float option -> unit

    /// <summary>
    /// Creates a new, blank ImageData object with the specified dimensions.
    /// </summary>
    /// <remarks>
    /// All pixels are transparent black.
    /// </remarks>
    /// <param name="width">The width to give the new ImageData object.</param>
    /// <param name="height">The height to give the new ImageData object.</param>
    /// <param name="settings">An object with color space settings.</param>
    /// <returns>A new ImageData object filled with transparent black pixels.</returns>
    abstract createImageData : width:int * height:int * ?settings: ImageDataSettings -> ImageData

    /// <summary>
    /// Creates a new ImageData object from an existing ImageData object.
    /// </summary>
    /// <param name="imagedata">An existing ImageData object from which to copy the width and height.</param>
    /// <returns>A new ImageData object with the same dimensions and filled with transparent black pixels.</returns>
    abstract createImageData : imagedata:ImageData -> ImageData

    /// <summary>
    /// Returns an ImageData object representing the underlying pixel data for a specified portion of the canvas.
    /// </summary>
    /// <remarks>
    /// This method is not affected by the canvas's transformation matrix. If the specified rectangle extends outside the bounds of the canvas, the pixels outside the canvas are transparent black in the returned ImageData object.
    /// </remarks>
    /// <param name="sx">The x-axis coordinate of the top-left corner of the rectangle from which the ImageData will be extracted.</param>
    /// <param name="sy">The y-axis coordinate of the top-left corner of the rectangle from which the ImageData will be extracted.</param>
    /// <param name="sw">The width of the rectangle from which the ImageData will be extracted. Positive values move to the right, and negative values to the left.</param>
    /// <param name="sh">The height of the rectangle from which the ImageData will be extracted. Positive values move down, and negative values move up.</param>
    /// <param name="settings">An optional object with settings properties.</param>
    /// <returns>An ImageData object containing the image data for the specified canvas rectangle.</returns>
    /// <exception ref="Exception">IndexSizeError: Thrown if either sw or sh are zero.</exception>
    /// <exception ref="Exception">SecurityError: The canvas contains or may contain pixels loaded from an origin other than the document's origin. To avoid a SecurityError, configure CORS to allow cross-origin use of images and canvas.</exception>
    abstract getImageData : sx:int * sy:int * sw:int * sh:int * ?settings:ImageDataSettings -> ImageData

    /// <summary>
    /// Paints data from the given ImageData object onto the canvas.
    /// </summary>
    /// <remarks>
    /// If a dirty rectangle is provided, only the pixels from that rectangle are painted. This method is not affected by the canvas transformation matrix.
    /// </remarks>
    /// <param name="imageData">An ImageData object containing the array of pixel values.</param>
    /// <param name="dx">Horizontal position (x coordinate) at which to place the image data in the destination canvas.</param>
    /// <param name="dy">Vertical position (y coordinate) at which to place the image data in the destination canvas.</param>
    /// <param name="dirtyX">Horizontal position (x coordinate) of the top-left corner from which the image data will be extracted. Defaults to 0.</param>
    /// <param name="dirtyY">Vertical position (y coordinate) of the top-left corner from which the image data will be extracted. Defaults to 0.</param>
    /// <param name="dirtyWidth">Width of the rectangle to be painted. Defaults to the width of the image data.</param>
    /// <param name="dirtyHeight">Height of the rectangle to be painted. Defaults to the height of the image data.</param>
    /// <exception ref="Exception">NotSupportedError: Thrown if any of the arguments is infinite.</exception>
    /// <exception ref="Exception">InvalidStateError: Thrown if the ImageData object's data has been detached.</exception>
    abstract putImageData : imageData:ImageData * dx:float * dy:float * ?dirtyX:float * ?dirtyY:float * ?dirtyWidth:float * ?dirtyHeight:float -> unit

    /// <summary>
    /// Gets or sets a value that determines whether scaled images are smoothed (true, default) or not (false).
    /// </summary>
    /// <remarks>
    /// On getting this property, the last value it was set to is returned. This property is useful for games and other apps that use pixel art. When enlarging images, the default resizing algorithm will blur the pixels. Set this property to false to retain the pixels' sharpness.
    /// </remarks>
    /// <value>
    /// A boolean value indicating whether to smooth scaled images or not. The default value is true.
    /// </value>
    abstract imageSmoothingEnabled : bool with get, set

    /// <summary>
    /// Gets or sets the quality of image smoothing.
    /// </summary>
    /// <remarks>
    /// Note: For this property to have an effect, imageSmoothingEnabled must be true.
    /// </remarks>
    abstract imageSmoothingQuality : ImageSmoothingQualityOptions with get, set

    /// <summary>
    /// Saves the entire state of the canvas by pushing the current state onto a stack.
    /// </summary>
    /// <remarks>
    /// The drawing state includes the current transformation matrix, clipping region, dash list, and the values of the following attributes: strokeStyle, fillStyle, globalAlpha, lineWidth, lineCap, lineJoin, miterLimit, lineDashOffset, shadowOffsetX, shadowOffsetY, shadowBlur, shadowColor, globalCompositeOperation, font, textAlign, textBaseline, direction, imageSmoothingEnabled.
    /// </remarks>
    abstract save : unit -> unit

    /// <summary>
    /// Restores the most recently saved canvas state by popping the top entry in the drawing state stack.
    /// </summary>
    /// <remarks>
    /// If there is no saved state, this method does nothing.
    /// </remarks>
    abstract restore : unit -> unit

    /// <summary>
    /// Gets a read-only reference to the HTMLCanvasElement object associated with this context.
    /// </summary>
    /// <value>A HTMLCanvasElement object or null if there is no associated &lt;canvas&gt; element.</value>
    abstract canvas : HTMLCanvasElement option

    /// <summary>
    /// Returns an object that contains attributes used by the context.
    /// </summary>
    /// <remarks>
    /// Note that context attributes may be requested when creating the context with HTMLCanvasElement.getContext(), but the attributes that are actually supported and used may differ.
    /// </remarks>
    /// <returns>A CanvasRenderingContext2DSettings object that contains the actual context parameters.</returns>
    abstract getContextAttributes : unit -> CanvasRenderingContext2DSettings

    /// <summary>
    /// Resets the rendering context to its default state, allowing it to be reused for drawing something else without having to explicitly reset all the properties.
    /// </summary>
    /// <remarks>
    /// Resetting clears the backing buffer, drawing state stack, any defined paths, and styles. This includes the current transformation matrix, compositing properties, clipping region, dash list, line styles, text styles, shadows, image smoothing, filters, and more.
    /// </remarks>
    abstract reset : unit -> unit

    /// <summary>
    /// Provides filter effects such as blurring and grayscaling for the rendering context.
    /// </summary>
    /// <remarks>
    /// It is similar to the CSS filter property and accepts the same values.
    /// </remarks>
    /// <value>
    /// A string representing the filter effect or "none" to clear the filter.
    /// </value>
    abstract member filter : string with get, set

namespace Browser

open Fable.Core
open Browser.Types

[<AutoOpen>]
module CanvasRenderingContext2D =
    [<Global>]
    let Path2D: Path2DStatic = jsNative<_>

    type HTMLCanvasElement with
        [<Emit("$0.getContext('2d', $1)")>]
        member _.getContext2d(?settings: CanvasRenderingContext2DSettings) = jsNative<CanvasRenderingContext2D>
