namespace Feliz.ViewEngine

open System
open Feliz.ViewEngine.Styles

//fsharplint:disable

/// Specifies a number of specialized CSS units
type length =
    /// Pixels are (1px = 1/96th of 1in).
    ///
    /// **Note**: Pixels (px) are relative to the viewing device. For low-dpi devices, 1px is one device pixel (dot) of the display. For printers and high resolution screens 1px implies multiple device pixels.
    static member inline px(value: int) : ICssUnit = string value + "px" |> CssUnit :> _
    /// Pixels are (1px = 1/96th of 1in).
    ///
    /// **Note**: Pixels (px) are relative to the viewing device. For low-dpi devices, 1px is one device pixel (dot) of the display. For printers and high resolution screens 1px implies multiple device pixels.
    static member inline px(value: double) : ICssUnit = string value + "px" |> CssUnit :> _
    /// Centimeters
    static member inline cm(value: int) : ICssUnit = string value + "cm" |> CssUnit :> _
    /// Centimeters
    static member inline cm(value: double) : ICssUnit = string value + "cm" |> CssUnit :> _
    /// Millimeters
    static member inline mm(value: int) : ICssUnit = string value + "mm" |> CssUnit :> _
    /// Millimeters
    static member inline mm(value: double) : ICssUnit = string value + "mm" |> CssUnit :> _
    /// Inches (1in = 96px = 2.54cm)
    static member inline inch(value: int) : ICssUnit = string value + "in" |> CssUnit :> _
    /// Inches (1in = 96px = 2.54cm)
    static member inline inch(value: double) : ICssUnit = string value + "in" |> CssUnit :> _
    /// Points (1pt = 1/72 of 1in)
    static member inline pt(value: int) : ICssUnit = string value + "pt" |> CssUnit :> _
    /// Points (1pt = 1/72 of 1in)
    static member inline pt(value: double) : ICssUnit = string value + "pt" |> CssUnit :> _
    /// Picas (1pc = 12 pt)
    static member inline pc(value: int) : ICssUnit = string value + "pc" |> CssUnit :> _
    /// Picas (1pc = 12 pt)
    static member inline pc(value: double) : ICssUnit = string value + "pc" |> CssUnit :> _
    /// Relative to the font-size of the element (2em means 2 times the size of the current font
    static member inline em(value: int) : ICssUnit = string value + "em" |> CssUnit :> _
    /// Relative to the font-size of the element (2em means 2 times the size of the current font
    static member inline em(value: double) : ICssUnit = string value + "em" |> CssUnit :> _
    /// Relative to the x-height of the current font (rarely used)
    static member inline ex(value: int) : ICssUnit = string value + "ex" |> CssUnit :> _
    /// Relative to the x-height of the current font (rarely used)
    static member inline ex(value: double) : ICssUnit = string value + "ex" |> CssUnit :> _
    /// Relative to width of the "0" (zero)
    static member inline ch(value: int) : ICssUnit = string value + "ch" |> CssUnit :> _
    /// Relative to font-size of the root element
    static member inline rem(value: double) : ICssUnit = string value + "rem" |> CssUnit :> _
    /// Relative to font-size of the root element
    static member inline rem(value: int) : ICssUnit = string value + "rem" |> CssUnit :> _
    /// Relative to 1% of the height of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vh(value: int) : ICssUnit = string value + "vh" |> CssUnit :> _
    /// Relative to 1% of the height of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vh(value: double) : ICssUnit = string value + "vh" |> CssUnit :> _
    /// Relative to 1% of the width of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vw(value: int) : ICssUnit = string value + "vw" |> CssUnit :> _
    /// Relative to 1% of the width of the viewport*
    ///
    /// **Viewport** = the browser window size. If the viewport is 50cm wide, 1vw = 0.5cm.
    static member inline vw(value: double) : ICssUnit = string value + "vw" |> CssUnit :> _
    /// Relative to 1% of viewport's smaller dimension
    static member inline vmin(value: double) : ICssUnit = string value + "vmin" |> CssUnit :> _
    /// Relative to 1% of viewport's smaller dimension
    static member inline vmin(value: int) : ICssUnit = string value + "vmin" |> CssUnit :> _
    /// Relative to 1% of viewport's larger dimension
    static member inline vmax(value: double) : ICssUnit = string value + "vmax" |> CssUnit :> _
    /// Relative to 1% of viewport's* larger dimension
    static member inline vmax(value: int) : ICssUnit = string value + "vmax" |> CssUnit :> _
    /// Relative to the parent element
    static member inline perc(value: int) : ICssUnit = string value + "%" |> CssUnit :> _
    /// Relative to the parent element
    static member inline perc(value: double) : ICssUnit = string value + "%" |> CssUnit :> _
    /// Relative to the parent element
    static member inline percent(value: int) : ICssUnit = string value + "%" |> CssUnit :> _
    /// Relative to the parent element
    static member inline percent(value: double) : ICssUnit = string value + "%" |> CssUnit :> _
    /// The browser calculates the length.
    static member inline auto : ICssUnit = "auto" |> CssUnit :> _

[<Erase>]
type style () =
    /// The zIndex property sets or returns the stack order of a positioned element.
    ///
    /// An element with greater stack order (1) is always in front of another element with lower stack order (0).
    ///
    /// **Tip**: A positioned element is an element with the position property set to: relative, absolute, or fixed.
    ///
    /// **Tip**: This property is useful if you want to create overlapping elements.
    static member inline zIndex(value: int) = Interop.mkStyle "z-index" value
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(value: int) = Interop.mkStyle "margin" (string value + "px")
    /// Sets the margin area on two sides of an element. It is a shorthand for margin-top and margin-right.
    static member inline margin(top: int, right: int) =
        Interop.mkStyle "margin" (
            (string top) + "px " +
            (string right) + "px"
        )
    /// Sets the margin area on two sides of an element. It is a shorthand for margin-top and margin-right.
    static member inline margin(top: ICssUnit, right: int) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right) + "px"
        )
    /// Sets the margin area on two sides of an element. It is a shorthand for margin-top and margin-right.
    static member inline margin(top: ICssUnit, right: ICssUnit) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right)
        )
    /// Sets the margin area on three sides of an element. It is a shorthand for margin-top, margin-right
    /// and margin-bottom.
    static member inline margin(top: ICssUnit, right: int, bottom: int) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right) + "px " +
            (string bottom) + "px"
        )
    /// Sets the margin area on three sides of an element. It is a shorthand for margin-top, margin-right
    /// and margin-bottom.
    static member inline margin(top: ICssUnit, right: ICssUnit, bottom: int) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right) + " " +
            (string bottom) + "px"
        )
    /// Sets the margin area on three sides of an element. It is a shorthand for margin-top, margin-right
    /// and margin-bottom.
    static member inline margin(top: ICssUnit, right: ICssUnit, bottom: ICssUnit) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right) + " " +
            (string bottom)
        )
    /// Sets the margin area on three sides of an element. It is a shorthand for margin-top, margin-right
    /// and margin-bottom.
    static member inline margin(top: ICssUnit, right: int, bottom: ICssUnit) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right) + "px " +
            (string bottom)
        )
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(top: ICssUnit, right: ICssUnit, bottom: ICssUnit, left: ICssUnit) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right) + " " +
            (string bottom) + " " +
            (string left)
        )
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(top: ICssUnit, right: int, bottom: int, left: int) =
        Interop.mkStyle "margin" (
            (string top) + " " +
            (string right) + "px " +
            (string bottom) + "px " +
            (string left) + "px"
        )
    /// Sets the margin area on two sides of an element. It is a shorthand for margin-top and margin-right.
    static member inline margin(top: int, right: ICssUnit) =
        Interop.mkStyle "margin" (
            (string top) + "px " +
            (string right)
        )
    /// Sets the margin area on three sides of an element. It is a shorthand for margin-top, margin-right
    /// and margin-bottom.
    static member inline margin(top: int, right: int, bottom: int) =
        Interop.mkStyle "margin" (
            (string top) + "px " +
            (string right) + "px " +
            (string bottom) + "px"
        )
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(top: int, right: int, bottom: int, left: int) =
        Interop.mkStyle "margin" (
            (string top) + "px " +
            (string right) + "px " +
            (string bottom) + "px " +
            (string left) + "px")
    /// Sets the margin area on all four sides of an element. It is a shorthand for margin-top, margin-right,
    /// margin-bottom, and margin-left.
    static member inline margin(value: ICssUnit) = Interop.mkStyle "margin" value
    /// Sets the margin area on the left side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginLeft(value: int) = Interop.mkStyle "margin-left" (string value + "px")
    /// Sets the margin area on the left side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginLeft(value: ICssUnit) = Interop.mkStyle "margin-left" value
    /// sets the margin area on the right side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginRight(value: int) = Interop.mkStyle "margin-right" (string value + "px")
    /// sets the margin area on the right side of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginRight(value: ICssUnit) = Interop.mkStyle "margin-right" value
    /// Sets the margin area on the top of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginTop(value: int) = Interop.mkStyle "margin-top" (string value + "px")
    /// Sets the margin area on the top of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginTop(value: ICssUnit) = Interop.mkStyle "margin-top" value
    /// Sets the margin area on the bottom of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginBottom(value: int) = Interop.mkStyle "margin-bottom" (string value + "px")
    /// Sets the margin area on the bottom of an element. A positive value places it farther from its
    /// neighbors, while a negative value places it closer.
    static member inline marginBottom(value: ICssUnit) = Interop.mkStyle "margin-bottom" value
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(top: ICssUnit, right: int) =
        Interop.mkStyle "padding" (
            (string top) + " " +
            (string right) + "px"
        )
    /// Sets the padding area on three sides of an element. It is a shorthand for padding-top,
    /// padding-right, and padding-bottom.
    static member inline padding(top: ICssUnit, right: int, bottom: int) =
        Interop.mkStyle "padding" (
            (string top) + " " +
            (string right) + "px " +
            (string bottom) + "px"
        )
    /// Sets the padding area on three sides of an element. It is a shorthand for padding-top,
    /// padding-right, and padding-bottom.
    static member inline padding(top: ICssUnit, right: ICssUnit, bottom: int) =
        Interop.mkStyle "padding" (
            (string top) + " " +
            (string right) + " " +
            (string bottom) + "px"
        )
    /// Sets the padding area on three sides of an element. It is a shorthand for padding-top,
    /// padding-right, and padding-bottom.
    static member inline padding(top: ICssUnit, right: ICssUnit, bottom: ICssUnit) =
        Interop.mkStyle "padding" (
            (string top) + " " +
            (string right) + " " +
            (string bottom)
        )
    /// Sets the padding area on three sides of an element. It is a shorthand for padding-top,
    /// padding-right, and padding-bottom.
    static member inline padding(top: ICssUnit, right: int, bottom: ICssUnit) =
        Interop.mkStyle "padding" (
            (string top) + " " +
            (string right) + "px " +
            (string bottom)
        )
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(top: ICssUnit, right: ICssUnit, bottom: ICssUnit, left: ICssUnit) =
        Interop.mkStyle "padding" (
            (string top) + " " +
            (string right) + " " +
            (string bottom) + " " +
            (string left)
        )
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(top: ICssUnit, right: int, bottom: int, left: int) =
        Interop.mkStyle "padding" (
            (string top) + " " +
            (string right) + "px " +
            (string bottom) + "px " +
            (string left) + "px"
        )
    /// Sets the padding area on two sides of an element. It is a shorthand for padding-top and padding-right.
    static member inline padding(top: int, right: ICssUnit) =
        Interop.mkStyle "padding" (
            (string top) + "px " +
            (string right)
        )
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(value: int) = Interop.mkStyle "padding" (string value + "px")
    /// Sets the padding area on two sides of an element. It is a shorthand for padding-top and padding-right.
    static member inline padding(top: int, right: int) =
        Interop.mkStyle "padding" (
            (string top) + "px " +
            (string right) + "px"
        )
    /// Sets the padding area on three sides of an element. It is a shorthand for padding-top,
    /// padding-right, and padding-bottom.
    static member inline padding(top: int, right: int, bottom: int) =
        Interop.mkStyle "padding" (
            (string top) + "px " +
            (string right) + "px " +
            (string bottom) + "px"
        )
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(top: int, right: int, bottom: int, left: int) =
        Interop.mkStyle "padding" (
            (string top) + "px " +
            (string right) + "px " +
            (string bottom) + "px " +
            (string left) + "px"
        )
    /// Sets the padding area on all four sides of an element. It is a shorthand for padding-top,
    /// padding-right, padding-bottom, and padding-left.
    static member inline padding(value: ICssUnit) = Interop.mkStyle "padding" value
    /// Sets the height of the padding area on the bottom of an element.
    static member inline paddingBottom(value: int) = Interop.mkStyle "padding-bottom" (string value + "px")
    /// Sets the height of the padding area on the bottom of an element.
    static member inline paddingBottom(value: ICssUnit) = Interop.mkStyle "padding-bottom" value
    /// Sets the width of the padding area to the left of an element.
    static member inline paddingLeft(value: int) = Interop.mkStyle "padding-left" (string value + "px")
    /// Sets the width of the padding area to the left of an element.
    static member inline paddingLeft(value: ICssUnit) = Interop.mkStyle "padding-left" value
    /// Sets the width of the padding area on the right of an element.
    static member inline paddingRight(value: int) = Interop.mkStyle "padding-right" (string value + "px")
    /// Sets the width of the padding area on the right of an element.
    static member inline paddingRight(value: ICssUnit) = Interop.mkStyle "padding-right" value
    /// Sets the height of the padding area on the top of an element.
    static member inline paddingTop(value: int) = Interop.mkStyle "padding-top" (string value + "px")
    /// Sets the height of the padding area on the top of an element.
    static member inline paddingTop(value: ICssUnit) = Interop.mkStyle "padding-top" value
    /// Sets the flex shrink factor of a flex item. If the size of all flex items is larger than
    /// the flex container, items shrink to fit according to flex-shrink.
    static member inline flexShrink(value: int) = Interop.mkStyle "flex-shrink" value
    /// Sets the initial main size of a flex item. It sets the size of the content box unless
    /// otherwise set with box-sizing.
    static member inline flexBasis (value: int) = Interop.mkStyle "flex-basis" value
    /// Sets the initial main size of a flex item. It sets the size of the content box unless
    /// otherwise set with box-sizing.
    static member inline flexBasis (value: float) = Interop.mkStyle "flex-basis" value
    /// Sets the initial main size of a flex item. It sets the size of the content box unless
    /// otherwise set with box-sizing.
    static member inline flexBasis (value: ICssUnit) = Interop.mkStyle "flex-basis" value
    /// Sets the flex grow factor of a flex item main size. It specifies how much of the remaining
    /// space in the flex container should be assigned to the item (the flex grow factor).
    static member inline flexGrow (value: int) = Interop.mkStyle "flex-grow" value
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDuration(timespan: TimeSpan) =
        Interop.mkStyle "transition-duration" (timespan.TotalMilliseconds.ToString() + "ms")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationSeconds(n: float) =
        Interop.mkStyle "transition-duration" (string n + "s")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationMilliseconds(n: float) =
        Interop.mkStyle "transition-duration" (string n + "ms")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationSeconds(n: int) =
        Interop.mkStyle "transition-duration" (string n + "s")
    /// Sets the length of time a transition animation should take to complete. By default, the
    /// value is 0s, meaning that no animation will occur.
    static member inline transitionDurationMilliseconds(n: int) =
        Interop.mkStyle "transition-duration" (string n + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelay(timespan: TimeSpan) =
        Interop.mkStyle "transition-delay" (timespan.TotalMilliseconds.ToString("0") + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelaySeconds(n: float) =
        Interop.mkStyle "transition-delay" (n.ToString("0") + "s")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelayMilliseconds(n: float) =
        Interop.mkStyle "transition-delay" (n.ToString("0") + "ms")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelaySeconds(n: int) =
        Interop.mkStyle "transition-delay" (string n + "s")
    /// Specifies the duration to wait before starting a property's transition effect when its value changes.
    static member inline transitionDelayMilliseconds(n: int) =
        Interop.mkStyle "transition-delay" (string n + "ms")
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty ([<ParamArray>] properties: ITransitionProperty[]) =
        let strings = properties |> Seq.map string
        Interop.mkStyle "transition-property" (String.concat "," strings)
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty (properties: ITransitionProperty list) =
        let strings = properties |> Seq.map string
        Interop.mkStyle "transition-property" (String.concat "," strings)
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty (property: ITransitionProperty) =
        Interop.mkStyle "transition-property" property
    /// Sets the CSS properties to which a transition effect should be applied.
    static member inline transitionProperty (property: string) =
        Interop.mkStyle "transition-property" property

    static member inline transform(transformation: ITransformProperty) =
        Interop.mkStyle "transform" transformation

    static member inline transform(transformations: ITransformProperty list) =
        let strings = transformations |> Seq.map string
        Interop.mkStyle "transform" (String.concat " " strings)

    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: int) = Interop.mkStyle "font-size" (string size + "px")
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: float) = Interop.mkStyle "font-size" (string size + "px")
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: ICssUnit) = Interop.mkStyle "font-size" size
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: int) = Interop.mkStyle "line-height" (string size + "px")
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: float) = Interop.mkStyle "line-height" (string size + "px")
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: ICssUnit) = Interop.mkStyle "line-height" size
    /// Sets the background color of an element.
    static member inline backgroundColor (color: string) = Interop.mkStyle "background-color" color
    /// Sets the foreground color value of an element's text and text decorations, and sets the
    /// `currentcolor` value. `currentcolor` may be used as an indirect value on other properties
    /// and is the default for other color properties, such as border-color.
    static member inline color (color: string) = Interop.mkStyle "color" color
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline top(value: int) = Interop.mkStyle "top" (string value + "px")
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline top(value: ICssUnit) = Interop.mkStyle "top" value
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline bottom(value: int) = Interop.mkStyle "bottom" (string value + "px")
    /// Specifies the vertical position of a positioned element. It has no effect on non-positioned elements.
    static member inline bottom(value: ICssUnit) = Interop.mkStyle "bottom" value
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline left(value: int) = Interop.mkStyle "left" (string value + "px")
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline left(value: ICssUnit) = Interop.mkStyle "left" value
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline right(value: int) = Interop.mkStyle "right" (string value + "px")
    /// Specifies the horizontal position of a positioned element. It has no effect on non-positioned elements.
    static member inline right(value: ICssUnit) = Interop.mkStyle "right" value
    /// Define a custom attribute of via key value pair
    static member inline custom(key: string, value: 't) = Interop.mkStyle key value
    /// Sets an element's bottom border. It sets the values of border-bottom-width,
    /// border-bottom-style and border-bottom-color.
    static member inline borderBottom(width: int, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-bottom" (
            (string width) + "px " +
            (string style) + " " +
            color
        )
    /// Sets an element's bottom border. It sets the values of border-bottom-width,
    /// border-bottom-style and border-bottom-color.
    static member inline borderBottom(width: ICssUnit, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-bottom" (
            (string width) + " " +
            (string style) + " " +
            color
        )

    /// An outline is a line around an element.
    /// It is displayed around the margin of the element. However, it is different from the border property.
    /// The outline is not a part of the element's dimensions, therefore the element's width and height properties do not contain the width of the outline.
    static member inline outlineWidth(width: int) =
        Interop.mkStyle "outline-width" (string width + "px")

    /// An outline is a line around an element.
    /// It is displayed around the margin of the element. However, it is different from the border property.
    /// The outline is not a part of the element's dimensions, therefore the element's width and height properties do not contain the width of the outline.
    static member inline outlineWidth(width: ICssUnit) =
        Interop.mkStyle "outline-width" width

    /// The outline-offset property adds space between an outline and the edge or border of an element.
    ///
    /// The space between an element and its outline is transparent.
    ///
    /// Outlines differ from borders in three ways:
    ///
    ///  - An outline is a line drawn around elements, outside the border edge
    ///  - An outline does not take up space
    ///  - An outline may be non-rectangular
    ///
    static member inline outlineOffset (offset:int) =
        Interop.mkStyle "outline-width" (offset.ToString() + "px")

    /// The outline-offset property adds space between an outline and the edge or border of an element.
    ///
    /// The space between an element and its outline is transparent.
    ///
    /// Outlines differ from borders in three ways:
    ///
    ///  - An outline is a line drawn around elements, outside the border edge
    ///  - An outline does not take up space
    ///  - An outline may be non-rectangular
    ///
    static member inline outlineOffset (offset:ICssUnit) =
        Interop.mkStyle "outline-width" offset

    /// An outline is a line that is drawn around elements (outside the borders) to make the element "stand out".
    ///
    /// The `outline-color` property specifies the color of an outline.

    /// **Note**: Always declare the outline-style property before the outline-color property. An element must have an outline before you change the color of it.
    static member inline outlineColor (color: string) =
        Interop.mkStyle "outline-color" color
    /// Set an element's left border.
    static member inline borderLeft(width: int, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-left" (
            (string width) + "px " +
            (string style) + " " +
            color
        )
    /// Set an element's left border.
    static member inline borderLeft(width: ICssUnit, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-bottom" (
            (string width) + " " +
            (string style) + " " +
            color
        )
    /// Set an element's right border.
    static member inline borderRight(width: int, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-right" (
            (string width) + "px " +
            (string style) + " " +
            color
        )
    /// Set an element's right border.
    static member inline borderRight(width: ICssUnit, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-right" (
            (string width) + " " +
            (string style) + " " +
            color
        )
    /// Set an element's top border.
    static member inline borderTop(width: int, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-top" (
            (string width) + "px " +
            (string style) + " " +
            color
        )
    /// Set an element's top border.
    static member inline borderTop(width: ICssUnit, style: IBorderStyle, color: string) =
        Interop.mkStyle "border-top" (
            (string width) + " " +
            (string style) + " " +
            color
        )
    /// Sets the line style of an element's bottom border.
    static member inline borderBottomStyle(style: IBorderStyle) = Interop.mkStyle "border-bottom-style" (string style)
    /// Sets the width of the bottom border of an element.
    static member inline borderBottomWidth (width: int) = Interop.mkStyle "border-bottom-width" (string width + "px")
    /// Sets the width of the bottom border of an element.
    static member inline borderBottomWidth (width: ICssUnit) = Interop.mkStyle "border-bottom-width" (string width)
    /// Sets the color of an element's bottom border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderBottomColor (color: string) = Interop.mkStyle "border-bottom-color" color
    /// Sets the line style of an element's top border.
    static member inline borderTopStyle(style: IBorderStyle) = Interop.mkStyle "border-top-style" (string style)
    /// Sets the width of the top border of an element.
    static member inline borderTopWidth (width: int) = Interop.mkStyle "border-top-width" (string width + "px")
    /// Sets the width of the top border of an element.
    static member inline borderTopWidth (width: ICssUnit) = Interop.mkStyle "border-top-width" (string width)
    /// Sets the color of an element's top border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderTopColor (color: string) = Interop.mkStyle "border-top-color" color
    /// /// Sets the line style of an element's right border.
    static member inline borderRightStyle(style: IBorderStyle) = Interop.mkStyle "border-right-style" (string style)
    /// Sets the width of the right border of an element.
    static member inline borderRightWidth (width: int) = Interop.mkStyle "border-right-width" (string width + "px")
    /// Sets the width of the right border of an element.
    static member inline borderRightWidth (width: ICssUnit) = Interop.mkStyle "border-right-width" (string width)
    /// Sets the color of an element's right border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderRightColor (color: string) = Interop.mkStyle "border-right-color" color
    /// Sets the line style of an element's left border.
    static member inline borderLeftStyle(style: IBorderStyle) = Interop.mkStyle "border-left-style" (string style)
    /// Sets the width of the left border of an element.
    static member inline borderLeftWidth (width: int) = Interop.mkStyle "border-left-width" (string width + "px")
    /// Sets the width of the left border of an element.
    static member inline borderLeftWidth (width: ICssUnit) = Interop.mkStyle "border-left-width" (string width)
    /// Sets the color of an element's left border.
    ///
    /// It can also be set with the shorthand CSS properties border-color or border-bottom.
    static member inline borderLeftColor (color: string) = Interop.mkStyle "border-left-color" color
    /// Sets an element's border.
    ///
    /// It sets the values of border-width, border-style, and border-color.
    static member inline border(width: int, style: IBorderStyle, color: string) =
        Interop.mkStyle "border" (
            (string width) + "px " +
            (string style) + " " +
            color
        )
    /// Sets an element's border.
    ///
    /// It sets the values of border-width, border-style, and border-color.
    static member inline border(width: ICssUnit, style: IBorderStyle, color: string) =
        Interop.mkStyle "border" (
            (string width) + " " +
            (string style) + " " +
            color
        )
    /// Sets an element's border.
    ///
    /// It sets the values of border-width, border-style, and border-color.
    static member inline border(width: string, style: IBorderStyle, color: string) =
        Interop.mkStyle "border" (
            (string width) + " " +
            (string style) + " " +
            color
        )
    /// Sets the line style for all four sides of an element's border.
    static member inline borderStyle (style: IBorderStyle) = Interop.mkStyle "border-style" style
    /// Sets the line style for all four sides of an element's border.
    static member inline borderStyle(top: IBorderStyle, right: IBorderStyle)  =
        Interop.mkStyle "border-style" ((string top) + " " + (string right))
    /// Sets the line style for all four sides of an element's border.
    static member inline borderStyle(top: IBorderStyle, right: IBorderStyle, bottom: IBorderStyle) =
        Interop.mkStyle "border-style" ((string top) + " " + (string right) + " " +  (string bottom))
    /// Sets the line style for all four sides of an element's border.
    static member inline borderStyle(top: IBorderStyle, right: IBorderStyle, bottom: IBorderStyle, left: IBorderStyle) =
        Interop.mkStyle "border-style" ((string top) + " " + (string right) + " " + (string bottom) + " " +  (string left))
    /// Sets the color of an element's border.
    static member inline borderColor (color: string) = Interop.mkStyle "border-color" color
    /// Rounds the corners of an element's outer border edge. You can set a single radius to make
    /// circular corners, or two radii to make elliptical corners.
    static member inline borderRadius (radius: int) = Interop.mkStyle "border-radius" radius
    /// Rounds the corners of an element's outer border edge. You can set a single radius to make
    /// circular corners, or two radii to make elliptical corners.
    static member inline borderRadius (radius: ICssUnit) = Interop.mkStyle "border-radius" radius
    /// Sets the width of an element's border.
    static member inline borderWidth (top: int, right: int) =
        Interop.mkStyle "border-width" (
            (string top) + "px " +
            (string right) + "px"
        )
    /// Sets the width of an element's border.
    static member inline borderWidth (width: int) = Interop.mkStyle "border-width" (string width + "px")
    /// Sets the width of an element's border.
    static member inline borderWidth (top: int, right: int, bottom: int) =
        Interop.mkStyle "border-width" (
            (string top) + "px " +
            (string right) + "px " +
            (string bottom) + "px"
        )
    /// Sets the width of an element's border.
    static member inline borderWidth (top: int, right: int, bottom: int, left: int) =
        Interop.mkStyle "border-width" (
            (string top) + "px " +
            (string right) + "px " +
            (string bottom) + "px " +
            (string left) + "px"
        )
    /// Sets one or more animations to apply to an element. Each name is an @keyframes at-rule that
    /// sets the property values for the animation sequence.
    static member inline animationName(keyframeName: string) = Interop.mkStyle "animation-name" keyframeName
    /// Sets the length of time that an animation takes to complete one cycle.
    static member inline animationDuration(timespan: TimeSpan) = Interop.mkStyle "animation-duration" (timespan.TotalMilliseconds.ToString() + "ms")
    /// Sets the length of time that an animation takes to complete one cycle.
    static member inline animationDuration(seconds: int) = Interop.mkStyle "animation-duration" (string seconds + "s")
    /// Sets when an animation starts.
    ///
    /// The animation can start later, immediately from its beginning, or immediately and partway through the animation.
    static member inline animationDelay(timespan: TimeSpan) = Interop.mkStyle "animation-delay" (timespan.TotalMilliseconds.ToString("0") + "ms")
    /// Sets when an animation starts.
    ///
    /// The animation can start later, immediately from its beginning, or immediately and partway through the animation.
    static member inline animationDelay(seconds: int) = Interop.mkStyle "animation-delay" (string seconds + "s")
    /// The number of times the animation runs.
    static member inline animationDurationCount(count: int) = Interop.mkStyle "animation-duration-count" count
    /// Sets the font family for the font specified in a @font-face rule.
    static member inline fontFamily (family: string) = Interop.mkStyle "font-family" family
    /// Defines from thin to thick characters. 400 is the same as normal, and 700 is the same as bold.
    /// Possible values are [100, 200, 300, 400, 500, 600, 700, 800, 900]
    static member inline fontWeight (weight: int) = Interop.mkStyle "font-weight" weight
    /// Sets the color of decorations added to text by text-decoration-line.
    static member inline textDecorationColor(color: string) = Interop.mkStyle "text-decoration-color" color
    /// Sets the kind of decoration that is used on text in an element, such as an underline or overline.
    static member inline textDecorationLine(line: ITextDecorationLine) = Interop.mkStyle "text-decoration-line" line
    /// Sets the appearance of decorative lines on text.
    ///
    /// It is a shorthand for text-decoration-line, text-decoration-color, text-decoration-style,
    /// and the newer text-decoration-thickness property.
    static member inline textDecoration(line: ITextDecorationLine) = Interop.mkStyle "text-decoration" line
    /// Sets the appearance of decorative lines on text.
    ///
    /// It is a shorthand for text-decoration-line, text-decoration-color, text-decoration-style,
    /// and the newer text-decoration-thickness property.
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine) =
        Interop.mkStyle "text-decoration" ((string bottom) + " " + (string top))
    /// Sets the appearance of decorative lines on text.
    ///
    /// It is a shorthand for text-decoration-line, text-decoration-color, text-decoration-style,
    /// and the newer text-decoration-thickness property.
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine, style: ITextDecoration) =
        Interop.mkStyle "text-decoration" ((string bottom) + " " + (string top) + " " + string style)
    /// Sets the appearance of decorative lines on text.
    ///
    /// It is a shorthand for text-decoration-line, text-decoration-color, text-decoration-style,
    /// and the newer text-decoration-thickness property.
    static member inline textDecoration(bottom: ITextDecorationLine, top: ITextDecorationLine, style: ITextDecoration, color: string) =
        Interop.mkStyle "text-decoration" ((string bottom) + " " + (string top) + " " + (string style) + " " + color)
    /// Sets the length of empty space (indentation) that is put before lines of text in a block.
    static member inline textIndent(value: int) = Interop.mkStyle "text-indent" value
    /// Sets the length of empty space (indentation) that is put before lines of text in a block.
    static member inline textIndent(value: string) = Interop.mkStyle "text-indent" value
    /// Sets the opacity of an element.
    ///
    /// Opacity is the degree to which content behind an element is hidden, and is the opposite of transparency.
    static member inline opacity(value: double) = Interop.mkStyle "opacity" value
    /// Sets the minimum width of an element.
    ///
    /// It prevents the used value of the width property from becoming smaller than the value specified for min-width.
    static member inline minWidth (value: int) = Interop.mkStyle "min-width" (string value + "px")
    /// Sets the minimum width of an element.
    ///
    /// It prevents the used value of the width property from becoming smaller than the value specified for min-width.
    static member inline minWidth (value: ICssUnit) = Interop.mkStyle "min-width" value
    /// Sets the initial position for each background image.
    ///
    /// The position is relative to the position layer set by background-origin.
    static member inline backgroundPosition  (position: string) = Interop.mkStyle "background-position" position
    /// Sets the type of cursor, if any, to show when the mouse pointer is over an element.
    static member inline cursor (value: string) = Interop.mkStyle "cursor" value
    /// Sets the minimum height of an element.
    ///
    /// It prevents the used value of the height property from becoming smaller than the value specified for min-height.
    static member inline minHeight (value: int) = Interop.mkStyle "min-height" (string value + "px")
    /// Sets the minimum height of an element.
    ///
    /// It prevents the used value of the height property from becoming smaller than the value specified for min-height.
    static member inline minHeight (value: ICssUnit) = Interop.mkStyle "min-height" value
    /// Sets the maximum width of an element.
    ///
    /// It prevents the used value of the width property from becoming larger than the value specified by max-width.
    static member inline maxWidth (value: int) = Interop.mkStyle "max-width" (string value + "px")
    /// Sets the maximum width of an element.
    ///
    /// It prevents the used value of the width property from becoming larger than the value specified by max-width.
    static member inline maxWidth (value: ICssUnit) = Interop.mkStyle "max-width" value
    /// Sets the maximum height of an element.
    ///
    /// It prevents the used value of the height property from becoming larger than the value specified for max-height.
    static member inline maxHeight (value: int) = Interop.mkStyle "max-height" (string value + "px")
    /// Sets the maximum height of an element.
    ///
    /// It prevents the used value of the height property from becoming larger than the value specified for max-height.
    static member inline maxHeight (value: ICssUnit) = Interop.mkStyle "max-height" value
    /// Set the height of an element.
    ///
    /// By default, the property defines the height of the content area.
    static member inline height (value: int) = Interop.mkStyle "height" (string value + "px")
    /// Set the height of an element.
    ///
    /// By default, the property defines the height of the content area.
    static member inline height (value: ICssUnit) = Interop.mkStyle "height" value
    /// Sets the width of an element.
    ///
    /// By default, the property defines the width of the content area.
    static member inline width (value: int) = Interop.mkStyle "width" (string value + "px")
    /// Sets the width of an element.
    ///
    /// By default, the property defines the width of the content area.
    static member inline width (value: ICssUnit) = Interop.mkStyle "width" value
    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    static member inline backgroundSize (value: string) = Interop.mkStyle "background-size" value
    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    static member inline backgroundSize (value: ICssUnit) = Interop.mkStyle "background-size" value
    /// Sets the size of the element's background image.
    ///
    /// The image can be left to its natural size, stretched, or constrained to fit the available space.
    static member inline backgroundSize (width: ICssUnit, height: ICssUnit) =
        Interop.mkStyle "background-size" (
            string width
            + " " +
            string height
        )

    /// Sets one or more background images on an element.
    static member inline backgroundImage (value: string) = Interop.mkStyle "background-image" value
    /// Short-hand for `style.backgroundImage(sprintf "url('%s')" value)` to set the backround image using a url.
    static member inline backgroundImageUrl (value: string) = Interop.mkStyle "background-image" ("url('" + value + "')")
    /// Sets how background images are repeated.
    ///
    /// A background image can be repeated along the horizontal and vertical axes, or not repeated at all.
    static member inline backgroundRepeat (repeat: IBackgroundRepeat) = Interop.mkStyle "background-repeat" repeat
    /// Adds shadow effects around an element's frame.
    ///
    /// A box shadow is described by X and Y offsets relative to the element, blur and spread radii, and color.
    static member inline boxShadow(horizontalOffset: int, verticalOffset: int, color: string) =
        Interop.mkStyle "box-shadow" (
            (string horizontalOffset) + "px " +
            (string verticalOffset) + "px " +
            color
        )
    /// Adds shadow effects around an element's frame.
    ///
    /// A box shadow is described by X and Y offsets relative to the element, blur and spread radii, and color.
    static member inline boxShadow(horizontalOffset: int, verticalOffset: int, blur: int, color: string) =
        Interop.mkStyle "box-shadow" (
            (string horizontalOffset) + "px " +
            (string verticalOffset) + "px " +
            (string blur) + "px " +
            color
        )
    /// Adds shadow effects around an element's frame.
    ///
    /// A box shadow is described by X and Y offsets relative to the element, blur and spread radii, and color.
    static member inline boxShadow(horizontalOffset: int, verticalOffset: int, blur: int, spread: int, color: string) =
        Interop.mkStyle "box-shadow" (
            (string horizontalOffset) + "px " +
            (string verticalOffset) + "px " +
            (string blur) + "px " +
            (string spread) + "px " +
            color
        )

[<Erase>]
module style =

    [<Erase>]
    type boxShadow =
        static member inline none = Interop.mkStyle "box-shadow" "none"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "box-shadow" "inherit"

    [<Erase>]
    type height =
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "height" "inherit"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "height" "initial"
        /// Resets this property to its inherited value if it inherits from its parent, and to its initial value if not.
        static member inline unset = Interop.mkStyle "height" "unset"

        /// The larger of either the intrinsic minimum height or the smaller of the intrinsic preferred height and the available height
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline fitContent = Interop.mkStyle "height" "fit-content"

        /// The intrinsic preferred height.
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline maxContent = Interop.mkStyle "height" "max-content"

        /// The intrinsic minimum height.
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline minContent = Interop.mkStyle "height" "min-content"

    [<Erase>]
    type minHeight =
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "min-height" "inherit"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "min-height" "initial"
        /// Resets this property to its inherited value if it inherits from its parent, and to its initial value if not.
        static member inline unset = Interop.mkStyle "min-height" "unset"

        /// The larger of either the intrinsic minimum height or the smaller of the intrinsic preferred height and the available height
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline fitContent = Interop.mkStyle "min-height" "fit-content"

        /// The intrinsic preferred height.
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline maxContent = Interop.mkStyle "min-height" "max-content"

        /// The intrinsic minimum height.
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline minContent = Interop.mkStyle "min-height" "min-content"

    [<Erase>]
    type maxHeight =
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "max-height" "inherit"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "max-height" "initial"
        /// Resets this property to its inherited value if it inherits from its parent, and to its initial value if not.
        static member inline unset = Interop.mkStyle "max-height" "unset"

        /// The larger of either the intrinsic minimum height or the smaller of the intrinsic preferred height and the available height
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline fitContent = Interop.mkStyle "max-height" "fit-content"

        /// The intrinsic preferred height.
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline maxContent = Interop.mkStyle "max-height" "max-content"

        /// The intrinsic minimum height.
        [<Experimental("This is an experimental API that should not be used in production code.")>]
        static member inline minContent = Interop.mkStyle "max-height" "min-content"

    [<Erase>]
    type textJustify =
        /// The browser determines the justification algorithm
        static member inline auto = Interop.mkStyle "text-justify" "auto"
        /// Increases/Decreases the space between words
        static member inline interWord = Interop.mkStyle "text-justify" "inter-word"
        /// Increases/Decreases the space between characters
        static member inline interCharacter = Interop.mkStyle "text-justify" "inter-character"
        /// Disables justification methods
        static member inline none = Interop.mkStyle "text-justify" "none"
        static member inline initial = Interop.mkStyle "text-justify" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "text-justify" "inherit"

    [<Erase>]
    type whitespace =
        /// Sequences of whitespace will collapse into a single whitespace. Text will wrap when necessary. This is default.
        static member inline normal = Interop.mkStyle "white-space" "normal"
        /// Sequences of whitespace will collapse into a single whitespace. Text will never wrap to the next line. The text continues on the same line until a `<br>` tag is encountered.
        static member inline nowrap = Interop.mkStyle "white-space" "nowrap"
        /// Whitespace is preserved by the browser. Text will only wrap on line breaks. Acts like the <pre> tag in HTML.
        static member inline pre = Interop.mkStyle "white-space" "pre"
        /// Sequences of whitespace will collapse into a single whitespace. Text will wrap when necessary, and on line breaks
        static member inline preline = Interop.mkStyle "white-space" "pre-line"
        /// Whitespace is preserved by the browser. Text will wrap when necessary, and on line breaks
        static member inline prewrap = Interop.mkStyle "white-space" "pre-wrap"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "white-space" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "white-space" "inherit"

    [<Erase>]
    type wordBreak =
        /// Default value. Uses default line break rules.
        static member inline normal = Interop.mkStyle "word-break" "normal"
        /// To prevent overflow, word may be broken at any character
        static member inline breakAll = Interop.mkStyle "word-break" "break-all"
        /// Word breaks should not be used for Chinese/Japanese/Korean (CJK) text. Non-CJK text behavior is the same as value "normal"
        static member inline keepAll = Interop.mkStyle "word-break" "keep-all"
        /// To prevent overflow, word may be broken at arbitrary points.
        static member inline breakWord = Interop.mkStyle "word-break" "break-word"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "word-break" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "word-break" "inherit"

    [<Erase>]
    type scrollBehavior =
        /// Allows a straight jump "scroll effect" between elements within the scrolling box. This is default
        static member inline auto = Interop.mkStyle "scroll-behavior" "auto"
        /// Allows a smooth animated "scroll effect" between elements within the scrolling box.
        static member inline smooth = Interop.mkStyle "scroll-behavior" "smooth"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "scroll-behavior" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "scroll-behavior" "inherit"

    [<Erase>]
    type overflow =
        /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
        static member inline visible = Interop.mkStyle "overflow" "visibile"
        /// The content is clipped - and no scrolling mechanism is provided.
        static member inline hidden = Interop.mkStyle "overflow" "hidden"
        /// The content is clipped and a scrolling mechanism is provided.
        static member inline scroll = Interop.mkStyle "overflow" "scroll"
        /// Should cause a scrolling mechanism to be provided for overflowing boxes
        static member inline auto = Interop.mkStyle "overflow" "auto"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "overflow" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "overflow" "inherit"

    [<Erase>]
    type overflowX =
        /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
        static member inline visible = Interop.mkStyle "overflow-x" "visibile"
        /// The content is clipped - and no scrolling mechanism is provided.
        static member inline hidden = Interop.mkStyle "overflow-x" "hidden"
        /// The content is clipped and a scrolling mechanism is provided.
        static member inline scroll = Interop.mkStyle "overflow-x" "scroll"
        /// Should cause a scrolling mechanism to be provided for overflowing boxes
        static member inline auto = Interop.mkStyle "overflow-x" "auto"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "overflow-x" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "overflow-x" "inherit"

    [<Erase>]
    type visibility =
        /// The element is hidden (but still takes up space).
        static member inline hidden = Interop.mkStyle "visibility" "hidden"
        /// Default value. The element is visible.
        static member inline visible = Interop.mkStyle "visibility" "visible"
        /// Only for table rows (`<tr>`), row groups (`<tbody>`), columns (`<col>`), column groups (`<colgroup>`). This value removes a row or column, but it does not affect the table layout. The space taken up by the row or column will be available for other content.
        ///
        /// If collapse is used on other elements, it renders as "hidden"
        static member inline collapse = Interop.mkStyle "visibility" "collapse"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "visibility" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "visibility" "inherit"

    [<Erase>]
    type flexBasis =
        /// Default value. The length is equal to the length of the flexible item. If the item has no length specified, the length will be according to its content.
        static member inline auto = Interop.mkStyle "flex-basis" "auto"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "flex-basis" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "flex-basis" "inherit"

    [<Erase>]
    type flexDirection =
        /// Default value. The flexible items are displayed horizontally, as a row
        static member inline row = Interop.mkStyle "flex-direction" "row"
        /// Same as row, but in reverse order.
        static member inline rowReverse = Interop.mkStyle "flex-direction" "row-reverse"
        /// The flexible items are displayed vertically, as a column
        static member inline column = Interop.mkStyle "flex-direction" "column"
        /// Same as column, but in reverse order
        static member inline columnReverse = Interop.mkStyle "flex-direction" "column-reverse"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "flex-basis" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "flex-basis" "inherit"

    [<Erase>]
    type flexWrap =
        /// Default value. Specifies that the flexible items will not wrap.
        static member inline nowrap = Interop.mkStyle "flex-wrap" "nowrap"
        /// Specifies that the flexible items will wrap if necessary
        static member inline wrap = Interop.mkStyle "flex-wrap" "wrap"
        /// Specifies that the flexible items will wrap, if necessary, in reverse order
        static member inline wrapReverse = Interop.mkStyle "flex-wrap" "wrap-reverse"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "flex-wrap" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "flex-wrap" "inherit"

    [<Erase>]
    type fontKerning =
        /// Default. The browser determines whether font kerning should be applied or not
        static member inline auto = Interop.mkStyle "font-kerning" "auto"
        /// Specifies that font kerning is applied
        static member inline normal = Interop.mkStyle "font-kerning" "normal"
        /// Specifies that font kerning is not applied
        static member inline none = Interop.mkStyle "font-kerning" "none"

    [<Erase>]
    /// The font-weight property sets how thick or thin characters in text should be displayed.
    type fontWeight =
        /// Defines normal characters. This is default.
        static member inline normal = Interop.mkStyle "font-weight" "normal"
        /// Defines thick characters.
        static member inline bold = Interop.mkStyle "font-weight" "bold"
        /// Defines thicker characters
        static member inline bolder = Interop.mkStyle "font-weight" "bolder"
        /// Defines lighter characters.
        static member inline lighter = Interop.mkStyle "font-weight" "lighter"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "font-weight" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "font-weight" "inherit"

    [<Erase>]
    type fontStyle =
        /// The browser displays a normal font style. This is defaut.
        static member inline normal = Interop.mkStyle "font-style" "normal"
        /// The browser displays an italic font style.
        static member inline italic = Interop.mkStyle "font-style" "italic"
        /// The browser displays an oblique font style.
        static member inline oblique = Interop.mkStyle "font-style" "oblique"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "font-style" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "font-style" "inherit"

    [<Erase>]
    type fontVariant =
        /// The browser displays a normal font. This is default
        static member inline normal = Interop.mkStyle "font-variant" "normal"
        /// The browser displays a small-caps font
        static member inline smallCaps = Interop.mkStyle "font-variant" "small-caps"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "font-variant" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "font-variant" "inherit"

    [<Erase>]
    type overflowY =
        /// The content is not clipped, and it may be rendered outside the left and right edges. This is default.
        static member inline visible = Interop.mkStyle "overflow-y" "visibile"
        /// The content is clipped - and no scrolling mechanism is provided.
        static member inline hidden = Interop.mkStyle "overflow-y" "hidden"
        /// The content is clipped and a scrolling mechanism is provided.
        static member inline scroll = Interop.mkStyle "overflow-y" "scroll"
        /// Should cause a scrolling mechanism to be provided for overflowing boxes
        static member inline auto = Interop.mkStyle "overflow-y" "auto"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "overflow-y" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "overflow-y" "inherit"

    [<Erase>]
    type wordWrap =
        /// Break words only at allowed break points
        static member inline normal = Interop.mkStyle "word-wrap" "normal"
        /// Allows unbreakable words to be broken
        static member inline breakWord = Interop.mkStyle "word-wrap" "break-word"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "word-wrap" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "word-wrap" "inherit"

    [<Erase>]
    type alignSelf =
        /// Default. The element inherits its parent container's align-items property, or "stretch" if it has no parent container.
        static member inline auto = Interop.mkStyle "align-self" "auto"
        /// The element is positioned to fit the container
        static member inline stretch = Interop.mkStyle "align-self" "stretch"
        /// The element is positioned at the center of the container
        static member inline center = Interop.mkStyle "align-self" "center"
        /// The element is positioned at the beginning of the container
        static member inline flexStart = Interop.mkStyle "align-self" "flex-start"
        /// The element is positioned at the end of the container
        static member inline flexEnd = Interop.mkStyle "align-self" "flex-end"
        /// The element is positioned at the baseline of the container
        static member inline baseline = Interop.mkStyle "align-self" "baseline"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "align-self" "initial"
        /// Inherits this property from its parent element
        static member inline inheritFromParent = Interop.mkStyle "align-self" "inherit"


    [<Erase>]
    type alignItems =
        /// Default. Items are stretched to fit the container
        static member inline stretch = Interop.mkStyle "align-items" "stretch"
        /// Items are positioned at the center of the container
        static member inline center = Interop.mkStyle "align-items"  "center"
        /// Items are positioned at the beginning of the container
        static member inline flexStart = Interop.mkStyle "align-items" "flex-start"
        /// Items are positioned at the end of the container
        static member inline flexEnd = Interop.mkStyle "align-items" "flex-end"
        /// Items are positioned at the baseline of the container
        static member inline baseline = Interop.mkStyle "align-items" "baseline"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "align-items"  "initial"
        /// Inherits this property from its parent element
        static member inline inheritFromParent = Interop.mkStyle "align-items"  "inherit"

    /// The `align-content` property modifies the behavior of the `flex-wrap` property.
    /// It is similar to align-items, but instead of aligning flex items, it aligns flex lines.
    ///
    /// **Note**: There must be multiple lines of items for this property to have any effect!
    ///
    /// **Tip**: Use the justify-content property to align the items on the main-axis (horizontally).
    [<Erase>]
    type alignContent =
        /// Default value. Lines stretch to take up the remaining space.
        static member inline stretch = Interop.mkStyle "align-content" "stretch"
        /// Lines are packed toward the center of the flex container.
        static member inline center = Interop.mkStyle "align-content" "center"
        /// Lines are packed toward the start of the flex container.
        static member inline flexStart = Interop.mkStyle "align-content" "flex-start"
        /// Lines are packed toward the end of the flex container.
        static member inline flexEnd = Interop.mkStyle "align-content" "flex-end"
        /// Lines are evenly distributed in the flex container.
        static member inline spaceBetween = Interop.mkStyle "align-content" "space-between"
        /// Lines are evenly distributed in the flex container, with half-size spaces on either end.
        static member inline spaceAround = Interop.mkStyle "align-content" "space-around"
        static member inline initial = Interop.mkStyle "align-content" "initial"
        static member inline inheritFromParent = Interop.mkStyle "align-content" "inherit"

    /// The justify-content property aligns the flexible container's items when the items do not use all available space on the main-axis (horizontally).
    ///
    /// See https://www.w3schools.com/cssref/css3_pr_justify-content.asp for reference.
    ///
    /// **Tip**: Use the align-items property to align the items vertically.
    [<Erase>]
    type justifyContent =
        /// Default value. Items are positioned at the beginning of the container.
        static member inline flexStart = Interop.mkStyle "justify-content" "flex-start"
        /// Items are positioned at the end of the container.
        static member inline flexEnd = Interop.mkStyle "justify-content" "flex-end"
        /// Items are positioned at the center of the container
        static member inline center = Interop.mkStyle "justify-content" "center"
        /// Items are positioned with space between the lines
        static member inline spaceBetween = Interop.mkStyle "justify-content" "space-between"
        /// Items are positioned with space before, between, and after the lines.
        static member inline spaceAround = Interop.mkStyle "justify-content" "space-around"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "justify-content" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "justify-content" "inherit"

    /// An outline is a line around an element.
    /// It is displayed around the margin of the element. However, it is different from the border property.
    /// The outline is not a part of the element's dimensions, therefore the element's width and height properties do not contain the width of the outline.
    [<Erase>]
    type outlineWidth =
        /// Specifies a medium outline. This is default.
        static member inline medium = Interop.mkStyle "outline-width" "medium"
        /// Specifies a thin outline.
        static member inline thin = Interop.mkStyle "outline-width" "thin"
        /// Specifies a thick outline.
        static member inline thick = Interop.mkStyle "outline-width" "thick"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "outline-width" "initial"
        /// Inherits this property from its parent element
        static member inline inheritFromParent = Interop.mkStyle "outline-width" "inherit"

    [<Erase>]
    type listStyleType =
        /// Default value. The marker is a filled circle
        static member inline disc = Interop.mkStyle "list-style-type" "disc"
        /// The marker is traditional Armenian numbering
        static member inline armenian = Interop.mkStyle "list-style-type" "armenian"
        /// The marker is a circle
        static member inline circle = Interop.mkStyle "list-style-type" "circle"
        /// The marker is plain ideographic numbers
        static member inline cjkIdeographic = Interop.mkStyle "list-style-type" "cjk-ideographic"
        /// The marker is a number
        static member inline decimal = Interop.mkStyle "list-style-type" "decimal"
        /// The marker is a number with leading zeros (01, 02, 03, etc.)
        static member inline decimalLeadingZero = Interop.mkStyle "list-style-type" "decimal-leading-zero"
        /// The marker is traditional Georgian numbering
        static member inline georgian = Interop.mkStyle "list-style-type" "georgian"
        /// The marker is traditional Hebrew numbering
        static member inline hebrew = Interop.mkStyle "list-style-type" "hebrew"
        /// The marker is traditional Hiragana numbering
        static member inline hiragana = Interop.mkStyle "list-style-type" "hiragana"
        /// The marker is traditional Hiragana iroha numbering
        static member inline hiraganaIroha = Interop.mkStyle "list-style-type" "hiragana-iroha"
        /// The marker is traditional Katakana numbering
        static member inline katakana = Interop.mkStyle "list-style-type" "katakana"
        /// The marker is traditional Katakana iroha numbering
        static member inline katakanaIroha = Interop.mkStyle "list-style-type" "katakana-iroha"
        /// The marker is lower-alpha (a, b, c, d, e, etc.)
        static member inline lowerAlpha = Interop.mkStyle "list-style-type" "lower-alpha"
        /// The marker is lower-greek
        static member inline lowerGreek = Interop.mkStyle "list-style-type" "lower-greek"
        /// The marker is lower-latin (a, b, c, d, e, etc.)
        static member inline lowerLatin = Interop.mkStyle "list-style-type" "lower-latin"
        /// The marker is lower-roman (i, ii, iii, iv, v, etc.)
        static member inline lowerRoman = Interop.mkStyle "list-style-type" "lower-roman"
        /// No marker is shown
        static member inline none = Interop.mkStyle "list-style-type" "none"
        /// The marker is a square
        static member inline square = Interop.mkStyle "list-style-type" "square"
        /// The marker is upper-alpha (A, B, C, D, E, etc.)
        static member inline upperAlpha = Interop.mkStyle "list-style-type" "upper-alpha"
        /// The marker is upper-greek
        static member inline upperGreek = Interop.mkStyle "list-style-type" "upper-greek"
        /// The marker is upper-latin (A, B, C, D, E, etc.)
        static member inline upperLatin = Interop.mkStyle "list-style-type" "upper-latin"
        /// The marker is upper-roman (I, II, III, IV, V, etc.)
        static member inline upperRoman = Interop.mkStyle "list-style-type" "upper-roman"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline initial = Interop.mkStyle "list-style-type" "initial"
        /// Inherits this property from its parent element.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline inheritFromParent = Interop.mkStyle "list-style-type" "inherit"

    type listStyleImage =
        /// No image will be displayed. Instead, the list-style-type property will define what type of list marker will be rendered. This is default
        static member inline none = Interop.mkStyle "list-style-image" "none"
        /// The path to the image to be used as a list-item marker
        static member inline url (path: string) = Interop.mkStyle "list-style-image" (sprintf "url('%s')" path)
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline initial = Interop.mkStyle "list-style-image" "initial"
        /// Inherits this property from its parent element.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline inheritFromParent = Interop.mkStyle "list-style-image" "inherit"

    [<Erase>]
    type listStylePosition =
        /// The bullet points will be inside the list item
        static member inline inside = Interop.mkStyle "list-style-position" "inside"
        /// The bullet points will be outside the list item. This is default
        static member inline outside = Interop.mkStyle "list-style-position" "outside"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline initial = Interop.mkStyle "list-style-position" "initial"
        /// Inherits this property from its parent element.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline inheritFromParent = Interop.mkStyle "list-style-position" "inherit"

    [<Erase>]
    type textAlign =
        /// Aligns the text to the left.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align
        static member inline left = Interop.mkStyle "text-align" "left"
        /// Aligns the text to the right.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=right
        static member inline right = Interop.mkStyle "text-align" "right"
        /// Centers the text.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=center
        static member inline center = Interop.mkStyle "text-align" "center"
        /// Stretches the lines so that each line has equal width (like in newspapers and magazines).
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=justify
        static member inline justify = Interop.mkStyle "text-align" "justify"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline initial = Interop.mkStyle "text-align" "initial"
        /// Inherits this property from its parent element.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-align&preval=initial
        static member inline inheritFromParent = Interop.mkStyle "text-align" "inherit"


    [<Erase>]
    type textDecorationLine =
        static member inline none = Interop.mkStyle "text-decoration-line" "none"
        static member inline underline = Interop.mkStyle "text-decoration-line" "underline"
        static member inline overline = Interop.mkStyle "text-decoration-line" "overline"
        static member inline lineThrough = Interop.mkStyle "text-decoration-line" "line-through"
        static member inline initial = Interop.mkStyle "text-decoration-line" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "text-decoration-line" "inherit"

    [<Erase>]
    type textDecoration =
        static member inline none = Interop.mkStyle "text-decoration" "none"
        static member inline underline = Interop.mkStyle "text-decoration" "underline"
        static member inline overline = Interop.mkStyle "text-decoration" "overline"
        static member inline lineThrough = Interop.mkStyle "text-decoration" "line-through"
        static member inline initial = Interop.mkStyle "text-decoration" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "text-decoration" "inherit"

    [<Erase>]
    /// The `transform-style` property specifies how nested elements are rendered in 3D space.
    type transformStyle =
        /// Specifies that child elements will NOT preserve its 3D position. This is default.
        static member inline flat = Interop.mkStyle "transform-style" "flat"
        /// Specifies that child elements will preserve its 3D position
        static member inline preserve3D = Interop.mkStyle "transform-style" "preserve-3d"
        static member inline initial = Interop.mkStyle "transform-style" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "transform-style" "inherit"

    [<Erase>]
    type textTransform =
        /// No capitalization. The text renders as it is. This is default.
        static member inline none = Interop.mkStyle "text-transform" "none"
        /// Transforms the first character of each word to uppercase.
        static member inline capitalize = Interop.mkStyle "text-transform" "capitalize"
        /// Transforms all characters to uppercase.
        static member inline uppercase = Interop.mkStyle "text-transform" "uppercase"
        /// Transforms all characters to lowercase.
        static member inline lowercase = Interop.mkStyle "text-transform" "lowercase"
        static member inline initial = Interop.mkStyle "text-transform" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "text-transform" "inherit"

    [<Erase>]
    type textOverflow =
        /// Default value. The text is clipped and not accessible.
        static member inline clip = Interop.mkStyle "text-overflow" "clip"
        /// Render an ellipsis ("...") to represent the clipped text.
        static member inline ellipsis = Interop.mkStyle "text-overflow" "ellipsis"
        /// Render the given string to represent the clipped text.
        static member inline custom(value: string) = Interop.mkStyle "text-overflow" value
        static member inline initial = Interop.mkStyle "text-overflow" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "text-overflow" "inherit"

    [<Erase>]
    /// Defines visual effects like blur and saturation to an element.
    type filter =
        /// Default value. Specifies no effects.
        static member inline none = Interop.mkStyle "filter" "none"
        /// Applies a blur effect to the elemeen. A larger value will create more blur.
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        static member inline blur(value: int) = Interop.mkStyle "filter" ("blur(" + string value + "%)")
        /// Applies a blur effect to the elemeen. A larger value will create more blur.
        ///
        /// This overload takes a floating number that goes from 0 to 1,
        static member inline blur(value: double) = Interop.mkStyle "filter" ("blur(" + string value + ")")
        /// Adjusts the brightness of the elemeen
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        ///
        /// Values over 100% will provide brighter results.
        static member inline brightness(value: int) = Interop.mkStyle "filter" ("brightness(" + string value + "%)")
        /// Adjusts the brightness of the elemeen. A larger value will create more blur.
        ///
        /// This overload takes a floating number that goes from 0 to 1,
        static member inline brightness(value: double) = Interop.mkStyle "filter" ("brightness(" + string value + ")")
        /// Adjusts the contrast of the element.
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        static member inline contrast(value: int) = Interop.mkStyle "filter" ("contrast(" + string value + "%)")
        /// Adjusts the contrast of the element. A larger value will create more contrast.
        ///
        /// This overload takes a floating number that goes from 0 to 1
        static member inline contrast(value: double) = Interop.mkStyle "filter" ("contrast(" + string value + ")")
        /// Applies a drop shadow effect.
        static member inline dropShadow(horizontalOffset: int, verticalOffset: int, blur: int, spread: int,  color: string) =
            Interop.mkStyle "filter" (
                "drop-shadow(" +
                (string horizontalOffset) + "px " +
                (string verticalOffset) + "px " +
                (string blur) + "px " +
                (string spread) + "px " +
                color +
                ")"
            )

        /// Applies a drop shadow effect.
        static member inline dropShadow(horizontalOffset: int, verticalOffset: int, blur: int, color: string) =
            Interop.mkStyle "filter" (
                "drop-shadow(" +
                (string horizontalOffset) + "px " +
                (string verticalOffset) + "px " +
                (string blur) + "px " +
                color +
                ")"
            )

        /// Applies a drop shadow effect.
        static member inline dropShadow(horizontalOffset: int, verticalOffset: int, color: string) =
            Interop.mkStyle "filter" (
                "drop-shadow(" +
                (string horizontalOffset) + "px " +
                (string verticalOffset) + "px " +
                color +
                ")"
            )

        /// Converts the image to grayscale
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        static member inline grayscale(value: int) = Interop.mkStyle "filter" ("grayscale(" + string value + "%)")
        /// Converts the image to grayscale
        ///
        /// This overload takes a floating number that goes from 0 to 1
        static member inline grayscale(value: double) = Interop.mkStyle "filter" ("grayscale(" + string value + ")")
        /// Applies a hue rotation on the image. The value defines the number of degrees around the color circle the image samples will be adjusted. 0deg is default, and represents the original image.
        ///
        /// **Note**: Maximum value is 360
        static member inline hueRotate(degrees: int) = Interop.mkStyle "filter" ("hue-rotate(" + string degrees + "deg)")
        /// Inverts the element.
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        static member inline invert(value: int) = Interop.mkStyle "filter" ("invert(" + string value + "%)")
        /// Inverts the element.
        ///
        /// This overload takes a floating number that goes from 0 to 1
        static member inline invert(value: double) = Interop.mkStyle "filter" ("invert(" + string value + ")")
        /// Sets the opacity of the element.
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        static member inline opacity(value: int) = Interop.mkStyle "filter" ("opacity(" + string value + "%)")
        /// Sets the opacity of the element.
        ///
        /// This overload takes a floating number that goes from 0 to 1
        static member inline opacity(value: double) = Interop.mkStyle "filter" ("opacity(" + string value + ")")
        /// Sets the saturation of the element.
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        static member inline saturate(value: int) = Interop.mkStyle "filter" ("saturate(" + string value + "%)")
        /// Sets the saturation of the element.
        ///
        /// This overload takes a floating number that goes from 0 to 1
        static member inline saturate(value: double) = Interop.mkStyle "filter" ("saturate(" + string value + ")")
        /// Applies Sepia filter to the element.
        ///
        /// This overload takes an integer that represents a percentage from 0 to 100.
        static member inline sepia(value: int) = Interop.mkStyle "filter" ("sepia(" + string value + "%)")
        /// Applies Sepia filter to the element.
        ///
        /// This overload takes a floating number that goes from 0 to 1
        static member inline sepia(value: double) = Interop.mkStyle "filter" ("sepia(" + string value + ")")
        /// The url() function takes the location of an XML file that specifies an SVG filter, and may include an anchor to a specific filter element.
        ///
        /// Example: `filter: url(svg-url#element-id)`
        static member inline url(value: string) = Interop.mkStyle "filter" ("url(" + value + ")")
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "filter" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "filter" "inherit"

    [<Erase>]
    /// Sets whether table borders should collapse into a single border or be separated as in standard HTML.
    type borderCollapse =
        /// Borders are separated; each cell will display its own borders. This is default.
        static member inline separate = Interop.mkStyle "border-collapse" "separate"
        /// Borders are collapsed into a single border when possible (border-spacing and empty-cells properties have no effect)
        static member inline collapse = Interop.mkStyle "border-collapse" "collapse"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "border-collapse" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "border-collapse" "inherit"

    [<Erase>]
    /// Specifies the size of the background images
    type backgroundSize =
        /// Default value. The background image is displayed in its original size
        ///
        /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=auto)
        static member inline auto = Interop.mkStyle "background-size" "auto"
        /// Resize the background image to cover the entire container, even if it has to stretch the image or cut a little bit off one of the edges.
        ///
        /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=cover)
        static member inline cover = Interop.mkStyle "background-size" "cover"
        /// Resize the background image to make sure the image is fully visible
        ///
        /// See [example here](https://www.w3schools.com/cssref/playit.asp?filename=playcss_background-size&preval=contain)
        static member inline contain = Interop.mkStyle "background-size" "contain"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "background-size" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "background-size" "inherit"

    [<Erase>]
    type textDecorationStyle =
        /// Default value. The line will display as a single line.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=solid
        static member inline solid = Interop.mkStyle "text-decoration-style" "solid"
        /// The line will display as a double line.
        ///
        /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=double
        static member inline double = Interop.mkStyle "text-decoration-style" "double"
        /// The line will display as a dotted line.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dotted
        static member inline dotted = Interop.mkStyle "text-decoration-style" "dotted"
        /// The line will display as a dashed line.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=dashed
        static member inline dashed = Interop.mkStyle "text-decoration-style" "dashed"
        /// The line will display as a wavy line.
        ///
        /// https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=wavy
        static member inline wavy = Interop.mkStyle "text-decoration-style" "wavy"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_text-decoration-style&preval=initial
        static member inline initial = Interop.mkStyle "text-decoration-style" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "text-decoration-style" "inherit"


    [<Erase>]
    type fontStretch =
        /// Makes the text as narrow as it gets.
        static member inline ultraCondensed = Interop.mkStyle "font-stretch" "ultra-condensed"
        /// Makes the text narrower than condensed, but not as narrow as ultra-condensed
        static member inline extraCondensed = Interop.mkStyle "font-stretch" "extra-condensed"
        /// Makes the text narrower than semi-condensed, but not as narrow as extra-condensed.
        static member inline condensed = Interop.mkStyle "font-stretch" "condensed"
        /// Makes the text narrower than normal, but not as narrow as condensed.
        static member inline semiCondensed = Interop.mkStyle "font-stretch" "semi-condensed"
        /// Default value. No font stretching
        static member inline normal = Interop.mkStyle "font-stretch" "normal"
        /// Makes the text wider than normal, but not as wide as expanded
        static member inline semiExpanded = Interop.mkStyle "font-stretch" "semi-expanded"
        /// Makes the text wider than semi-expanded, but not as wide as extra-expanded
        static member inline expanded = Interop.mkStyle "font-stretch" "expanded"
        /// Makes the text wider than expanded, but not as wide as ultra-expanded
        static member inline extraExpanded = Interop.mkStyle "font-stretch" "extra-expanded"
        /// Makes the text as wide as it gets.
        static member inline ultraExpanded = Interop.mkStyle "font-stretch" "ultra-expanded"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "font-stretch" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "font-stretch" "inherit"

    [<Erase>]
    /// Specifies how an element should float.
    ///
    /// **Note**: Absolutely positioned elements ignores the float property!
    type floatStyle =
        /// The element does not float, (will be displayed just where it occurs in the text). This is default
        static member inline none = Interop.mkStyle "float" "none"
        static member inline left = Interop.mkStyle "float" "left"
        static member inline right = Interop.mkStyle "float" "right"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "float" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "float" "inherit"

    [<Erase>]
    type verticalAlign =
        /// The element is aligned with the baseline of the parent. This is default.
        static member inline baseline = Interop.mkStyle "vertical-align" "baseline"
        /// The element is aligned with the subscript baseline of the parent
        static member inline sub = Interop.mkStyle "vertical-align" "sup"
        /// The element is aligned with the superscript baseline of the parent.
        static member inline super = Interop.mkStyle "vertical-align" "super"
        /// The element is aligned with the top of the tallest element on the line.
        static member inline top = Interop.mkStyle "vertical-align" "top"
        /// The element is aligned with the top of the parent element's font.
        static member inline textTop = Interop.mkStyle "vertical-align" "text-top"
        /// The element is placed in the middle of the parent element.
        static member inline middle = Interop.mkStyle "vertical-align" "middle"
        /// The element is aligned with the lowest element on the line.
        static member inline bottom = Interop.mkStyle "vertical-align" "bottom"
        /// The element is aligned with the bottom of the parent element's font
        static member inline textBottom = Interop.mkStyle "vertical-align" "text-bottom"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "vertical-align" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "vertical-align" "inherit"

    [<Erase>]
    /// Specifies whether lines of text are laid out horizontally or vertically.
    type writingMode =
        /// Let the content flow horizontally from left to right, vertically from top to bottom
        static member inline horizontalTopBottom = Interop.mkStyle "writing-mode" "horizontal-tb"
        /// Let the content flow vertically from top to bottom, horizontally from right to left
        static member inline verticalRightLeft = Interop.mkStyle "writing-mode" "vertical-rl"
        /// Let the content flow vertically from top to bottom, horizontally from left to right
        static member inline verticalLeftRight = Interop.mkStyle "writing-mode" "vertical-lr"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "writing-mode" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "writing-mode" "inherit"

    [<Erase>]
    type animationTimingFunction =
        /// Default value. Specifies a animation effect with a slow start, then fast, then end slowly (equivalent to cubic-bezier(0.25,0.1,0.25,1)).
        static member inline ease = Interop.mkStyle "animation-timing-function" "ease"
        /// Specifies a animation effect with the same speed from start to end (equivalent to cubic-bezier(0,0,1,1))
        static member inline linear = Interop.mkStyle "animation-timing-function" "linear"
        /// Specifies a animation effect with a slow start (equivalent to cubic-bezier(0.42,0,1,1)).
        static member inline easeIn = Interop.mkStyle "animation-timing-function" "ease-in"
        /// Specifies a animation effect with a slow end (equivalent to cubic-bezier(0,0,0.58,1)).
        static member inline easeOut = Interop.mkStyle "animation-timing-function" "ease-out"
        /// Specifies a animation effect with a slow start and end (equivalent to cubic-bezier(0.42,0,0.58,1))
        static member inline easeInOut = Interop.mkStyle "animation-timing-function" "ease-in-out"
        /// Define your own values in the cubic-bezier function. Possible values are numeric values from 0 to 1
        static member inline cubicBezier(n1: float, n2: float, n3: float, n4: float) =
            Interop.mkStyle "animation-timing-function" (
                "cubic-bezier(" + string n1 + "," +
                string n2 + "," +
                string n3 + "," +
                string n4 + ")"
            )
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "animation-timing-function" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "animation-timing-function" "inherit"

    [<Erase>]
    type transitionTimingFunction =
        /// Default value. Specifies a transition effect with a slow start, then fast, then end slowly (equivalent to cubic-bezier(0.25,0.1,0.25,1)).
        static member inline ease = Interop.mkStyle "transition-timing-function" "ease"
        /// Specifies a transition effect with the same speed from start to end (equivalent to cubic-bezier(0,0,1,1))
        static member inline linear = Interop.mkStyle "transition-timing-function" "linear"
        /// Specifies a transition effect with a slow start (equivalent to cubic-bezier(0.42,0,1,1)).
        static member inline easeIn = Interop.mkStyle "transition-timing-function" "ease-in"
        /// Specifies a transition effect with a slow end (equivalent to cubic-bezier(0,0,0.58,1)).
        static member inline easeOut = Interop.mkStyle "transition-timing-function" "ease-out"
        /// Specifies a transition effect with a slow start and end (equivalent to cubic-bezier(0.42,0,0.58,1))
        static member inline easeInOut = Interop.mkStyle "transition-timing-function" "ease-in-out"
        /// Equivalent to steps(1, start)
        static member inline stepStart = Interop.mkStyle "transition-timing-function" "step-start"
        /// Equivalent to steps(1, end)
        static member inline stepEnd = Interop.mkStyle "transition-timing-function" "step-end"
        static member inline stepsToEnd(steps: int) =
            Interop.mkStyle "transition-timing-function" ("steps(" + string steps + ", end)")
        static member inline stepsToStart(steps: int) =
            Interop.mkStyle "transition-timing-function" ("steps(" + string steps + ", start)")
        /// Define your own values in the cubic-bezier function. Possible values are numeric values from 0 to 1
        static member inline cubicBezier(n1: float, n2: float, n3: float, n4: float) =
            Interop.mkStyle "transition-timing-function" (
                "cubic-bezier(" + string n1 + "," +
                string n2 + "," +
                string n3 + "," +
                string n4 + ")"
            )
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "transition-timing-function" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "transition-timing-function" "inherit"

    [<Erase>]
    type userSelect =
        /// Default. Text can be selected if the browser allows it.
        static member inline auto = Interop.mkStyle "user-select" "auto"
        /// Prevents text selection.
        static member inline none = Interop.mkStyle "user-select" "none"
        /// The text can be selected by the user.
        static member inline text = Interop.mkStyle "user-select" "text"
        /// Text selection is made with one click instead of a double-click.
        static member inline all = Interop.mkStyle "user-select" "all"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "user-select" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "user-select" "inherit"

    [<Erase>]
    type borderStyle =
        /// Specifies a dotted border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline dotted = Interop.mkStyle "border-style" "dotted"
        /// Specifies a dashed border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline dashed = Interop.mkStyle "border-style" "dashed"
        /// Specifies a solid border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline solid = Interop.mkStyle "border-style" "solid"
        /// Specifies a double border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline double = Interop.mkStyle "border-style" "double"
        /// Specifies a 3D grooved border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline groove = Interop.mkStyle "border-style" "groove"
        /// Specifies a 3D ridged border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline ridge = Interop.mkStyle "border-style" "ridge"
        /// Specifies a 3D inset border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline inset = Interop.mkStyle "border-style" "inset"
        /// Specifies a 3D outset border. The effect depends on the border-color value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline outset = Interop.mkStyle "border-style" "outset"
        /// Default value. Specifies no border.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=dotted
        static member inline none = Interop.mkStyle "border-style" "none"
        /// The same as "none", except in border conflict resolution for table elements.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
        static member inline hidden = Interop.mkStyle "border-style" "hidden"
        /// Sets this property to its default value.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
        ///
        /// Read about initial value https://www.w3schools.com/cssref/css_initial.asp
        static member inline initial = Interop.mkStyle "border-style" "initial"
        /// Inherits this property from its parent element.
        ///
        /// See example https://www.w3schools.com/cssref/playit.asp?filename=playcss_border-style&preval=hidden
        ///
        /// Read about inherit https://www.w3schools.com/cssref/css_inherit.asp
        static member inline inheritFromParent = Interop.mkStyle "border-style" "inherit"

    [<Erase>]
    /// Defines the algorithm used to lay out table cells, rows, and columns.
    ///
    /// **Tip:** The main benefit of table-layout: fixed; is that the table renders much faster. On large tables, users will not see any part of the table until the browser has rendered the whole table. So, if you use table-layout: fixed, users will see the top of the table while the browser loads and renders rest of the table. This gives the impression that the page loads a lot quicker!
    type tableLayout =
        /// Browsers use an automatic table layout algorithm. The column width is set by the widest unbreakable content in the cells. The content will dictate the layout
        static member inline auto = Interop.mkStyle "table-layout" "auto"
        /// Sets a fixed table layout algorithm. The table and column widths are set by the widths of table and col or by the width of the first row of cells. Cells in other rows do not affect column widths. If no widths are present on the first row, the column widths are divided equally across the table, regardless of content inside the cells
        static member inline fixed' = Interop.mkStyle "table-layout" "fixed"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "table-layout" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "table-layout" "inherit"

    [<Erase>]
    type display =
        /// Displays an element as an inline element (like `<span>`). Any height and width properties will have no effect.
        static member inline inlineElement = Interop.mkStyle "display" "inline"
        /// Displays an element as a block element (like `<p>`). It starts on a new line, and takes up the whole width.
        static member inline block = Interop.mkStyle "display" "block"
        /// Makes the container disappear, making the child elements children of the element the next level up in the DOM.
        static member inline contents = Interop.mkStyle "display" "contents"
        /// Displays an element as a block-level flex container.
        static member inline flex = Interop.mkStyle "display" "flex"
        /// Displays an element as a block container box, and lays out its contents using flow layout.
        ///
        /// It always establishes a new block formatting context for its contents.
        static member inline flowRoot = Interop.mkStyle "display" "flow-root"
        /// Displays an element as a block-level grid container.
        static member inline grid = Interop.mkStyle "display" "grid"
        /// Displays an element as an inline-level block container. The element itself is formatted as an inline element, but you can apply height and width values.
        static member inline inlineBlock = Interop.mkStyle "display" "inline-block"
        /// Displays an element as an inline-level flex container.
        static member inline inlineFlex = Interop.mkStyle "display" "inline-flex"
        /// Displays an element as an inline-level grid container
        static member inline inlineGrid = Interop.mkStyle "display" "inline-grid"
        /// The element is displayed as an inline-level table.
        static member inline inlineTable = Interop.mkStyle "display" "inline-table"
        /// Let the element behave like a `<li>` element
        static member inline listItem = Interop.mkStyle "display" "list-item"
        /// Displays an element as either block or inline, depending on context.
        static member inline runIn = Interop.mkStyle "display" "run-in"
        /// Let the element behave like a `<table>` element.
        static member inline table = Interop.mkStyle "display" "table"
        /// Let the element behave like a <caption> element.
        static member inline tableCaption = Interop.mkStyle "display" "table-caption"
        /// Let the element behave like a <colgroup> element.
        static member inline tableColumnGroup = Interop.mkStyle "display" "table-column-group"
        /// Let the element behave like a <thead> element.
        static member inline tableHeaderGroup = Interop.mkStyle "display" "table-header-group"
        /// Let the element behave like a <tfoot> element.
        static member inline tableFooterGroup = Interop.mkStyle "display" "table-footer-group"
        /// Let the element behave like a <tbody> element.
        static member inline tableRowGroup = Interop.mkStyle "display" "table-row-group"
        /// Let the element behave like a <td> element.
        static member inline tableCell = Interop.mkStyle "display" "table-cell"
        /// Let the element behave like a <col> element.
        static member inline tableColumn = Interop.mkStyle "display" "table-column"
        /// Let the element behave like a <tr> element.
        static member inline tableRow = Interop.mkStyle "display" "table-row"
        /// The element is completely removed.
        static member inline none = Interop.mkStyle "display" "none"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "display" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "display" "inherit"

    [<Erase>]
    /// The cursor CSS property sets the type of cursor, if any, to show when the mouse pointer is over an element.
    /// See documentation at https://developer.mozilla.org/en-US/docs/Web/CSS/cursor
    type cursor =
        /// The User Agent will determine the cursor to display based on the current context. E.g., equivalent to text when hovering text.
        static member inline auto = Interop.mkStyle "cursor" "auto"
        /// The cursor indicates an alias of something is to be created
        static member inline alias = Interop.mkStyle "cursor" "alias"
        /// The platform-dependent default cursor. Typically an arrow.
        static member inline defaultCursor = Interop.mkStyle "cursor" "default"
        /// No cursor is rendered.
        static member inline none = Interop.mkStyle "cursor" "none"
        /// A context menu is available.
        static member inline contextMenu = Interop.mkStyle "cursor" "context-menu"
        /// Help information is available.
        static member inline help = Interop.mkStyle "cursor" "help"
        /// The cursor is a pointer that indicates a link. Typically an image of a pointing hand.
        static member inline pointer = Interop.mkStyle "cursor" "pointer"
        /// The program is busy in the background, but the user can still interact with the interface (in contrast to `wait`).
        static member inline progress = Interop.mkStyle "cursor" "progress"
        /// The program is busy, and the user can't interact with the interface (in contrast to progress). Sometimes an image of an hourglass or a watch.
        static member inline wait = Interop.mkStyle "cursor" "wait"
        /// The table cell or set of cells can be selected.
        static member inline cell = Interop.mkStyle "cursor" "cell"
        /// Cross cursor, often used to indicate selection in a bitmap.
        static member inline crosshair = Interop.mkStyle "cursor" "crosshair"
        /// The text can be selected. Typically the shape of an I-beam.
        static member inline text = Interop.mkStyle "cursor" "text"
        /// The vertical text can be selected. Typically the shape of a sideways I-beam.
        static member inline verticalText = Interop.mkStyle "cursor" "vertical-text"
        /// Something is to be copied.
        static member inline copy = Interop.mkStyle "cursor" "copy"
        /// Something is to be moved.
        static member inline move = Interop.mkStyle "cursor" "move"
        /// An item may not be dropped at the current location. On Windows and Mac OS X, `no-drop` is the same as `not-allowed`.
        static member inline noDrop = Interop.mkStyle "cursor" "no-drop"
        /// The requested action will not be carried out.
        static member inline notAllowed = Interop.mkStyle "cursor" "not-allowed"
        /// Something can be grabbed (dragged to be moved).
        static member inline grab = Interop.mkStyle "cursor" "grab"
        /// Something is being grabbed (dragged to be moved).
        static member inline grabbing = Interop.mkStyle "cursor" "grabbing"
        /// Something can be scrolled in any direction (panned).
        static member inline allScroll = Interop.mkStyle "cursor" "all-scroll"
        /// The item/column can be resized horizontally. Often rendered as arrows pointing left and right with a vertical bar separating them.
        static member inline columnResize = Interop.mkStyle "cursor" "col-resize"
        /// The item/row can be resized vertically. Often rendered as arrows pointing up and down with a horizontal bar separating them.
        static member inline rowResize = Interop.mkStyle "cursor" "row-resize"
        /// Directional resize arrow
        static member inline northResize = Interop.mkStyle "cursor" "n-resize"
        /// Directional resize arrow
        static member inline eastResize = Interop.mkStyle "cursor" "e-resize"
        /// Directional resize arrow
        static member inline southResize = Interop.mkStyle "cursor" "s-resize"
        /// Directional resize arrow
        static member inline westResize = Interop.mkStyle "cursor" "w-resize"
        /// Directional resize arrow
        static member inline northEastResize = Interop.mkStyle "cursor" "ne-resize"
        /// Directional resize arrow
        static member inline northWestResize = Interop.mkStyle "cursor" "nw-resize"
        /// Directional resize arrow
        static member inline southEastResize = Interop.mkStyle "cursor" "se-resize"
        /// Directional resize arrow
        static member inline southWestResize = Interop.mkStyle "cursor" "sw-resize"
        /// Directional resize arrow
        static member inline eastWestResize = Interop.mkStyle "cursor" "ew-resize"
        /// Directional resize arrow
        static member inline northSouthResize = Interop.mkStyle "cursor" "ns-resize"
        /// Directional resize arrow
        static member inline northEastSouthWestResize = Interop.mkStyle "cursor" "nesw-resize"
        /// Directional resize arrow
        static member inline northWestSouthEastResize = Interop.mkStyle "cursor" "nwse-resize"
        /// Something can be zoomed (magnified) in
        static member inline zoomIn = Interop.mkStyle "cursor" "zoom-in"
        /// Something can be zoomed out
        static member inline zoomOut = Interop.mkStyle "cursor" "zoom-out"

    /// An outline is a line that is drawn around elements (outside the borders) to make the element "stand out".
    ///
    /// The outline-style property specifies the style of an outline.
    ///
    /// An outline is a line around an element. It is displayed around the margin of the element. However, it is different from the border property.
    ///
    /// The outline is not a part of the element's dimensions, therefore the element's width and height properties do not contain the width of the outline.
    [<Erase>]
    type outlineStyle =
        /// Specifies no outline. This is default.
        static member inline none = Interop.mkStyle "outline-style" "none"
        /// Specifies a hidden outline
        static member inline hidden = Interop.mkStyle "outline-style" "hidden"
        /// Specifies a dotted outline
        static member inline dotted = Interop.mkStyle "outline-style" "dotted"
        /// Specifies a dashed outline
        static member inline dashed = Interop.mkStyle "outline-style" "dashed"
        /// Specifies a solid outline
        static member inline solid = Interop.mkStyle "outline-style" "solid"
        /// Specifies a double outliner
        static member inline double = Interop.mkStyle "outline-style" "double"
        /// Specifies a 3D grooved outline. The effect depends on the outline-color value
        static member inline groove = Interop.mkStyle "outline-style" "groove"
        /// Specifies a 3D ridged outline. The effect depends on the outline-color value
        static member inline ridge = Interop.mkStyle "outline-style" "ridge"
        /// Specifies a 3D inset  outline. The effect depends on the outline-color value
        static member inline inset = Interop.mkStyle "outline-style" "inset"
        /// Specifies a 3D outset outline. The effect depends on the outline-color value
        static member inline outset = Interop.mkStyle "outline-style" "outset"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "outline-style" "initial"
        /// Inherits this property from its parent element
        static member inline inheritFromParent = Interop.mkStyle "outline-style" "inherit"

    [<Erase>]
    type backgroundPosition =
        /// The background image will scroll with the page. This is default.
        static member inline scroll = Interop.mkStyle "background-position" "scroll"
        /// The background image will not scroll with the page.
        static member inline fixedNoScroll = Interop.mkStyle "background-position" "fixed"
        /// The background image will scroll with the element's contents.
        static member inline local = Interop.mkStyle "background-position" "local"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "background-position" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "background-position" "inherit"

    [<Erase>]
    /// This property defines the blending mode of each background layer (color and/or image).
    type backgroundBlendMode =
        /// This is default. Sets the blending mode to normal.
        static member inline normal = Interop.mkStyle "background-blend-mode" "normal"
        /// Sets the blending mode to screen
        static member inline screen = Interop.mkStyle "background-blend-mode" "screen"
        /// Sets the blending mode to overlay
        static member inline overlay = Interop.mkStyle "background-blend-mode" "overlay"
        /// Sets the blending mode to darken
        static member inline darken = Interop.mkStyle "background-blend-mode" "darken"
        /// Sets the blending mode to multiply
        static member inline lighten = Interop.mkStyle "background-blend-mode" "lighten"
        /// Sets the blending mode to color-dodge
        static member inline collorDodge = Interop.mkStyle "background-blend-mode" "color-dodge"
        /// Sets the blending mode to saturation
        static member inline saturation = Interop.mkStyle "background-blend-mode" "saturation"
        /// Sets the blending mode to color
        static member inline color = Interop.mkStyle "background-blend-mode" "color"
        /// Sets the blending mode to luminosity
        static member inline luminosity = Interop.mkStyle "background-blend-mode" "luminosity"

    [<Erase>]
    /// Defines how far the background (color or image) should extend within an element.
    type backgroundClip =
        /// Default value. The background extends behind the border.
        static member inline borderBox = Interop.mkStyle "background-clip" "border-box"
        /// The background extends to the inside edge of the border.
        static member inline paddingBox = Interop.mkStyle "background-clip" "padding-box"
        /// The background extends to the edge of the content box.
        static member inline contentBox = Interop.mkStyle "background-clip" "content-box"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "background-clip" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "background-clip" "inherit"

    [<Erase>]
    type transform =
        /// Defines that there should be no transformation.
        static member inline none = Interop.mkStyle "transform" "none"
        /// Defines a 2D transformation, using a matrix of six values.
        static member inline matrix(x1: int, y1: int, z1: int, x2: int, y2: int, z2: int) =
            Interop.mkStyle "transform" (
                "matrix(" +
                string x1 + "," +
                string y1 + "," +
                string z1 + "," +
                string x2 + "," +
                string y2 + "," +
                string z2 + ")"
            )

        /// Defines a 2D translation.
        static member inline translate(x: int, y: int) =
            Interop.mkStyle "transform" (
                "translate(" + string x + "," + string y + ")"
            )


        /// Defines that there should be no transformation.
        static member inline translate3D(x: int, y: int, z: int) =
            Interop.mkStyle "transform" (
                "translate3d(" + string x + "," + string y + "," + string z + ")"
            )

        /// Defines a translation, using only the value for the X-axis.
        static member inline translateX(x: int) =
            Interop.mkStyle "transform" ("translateX(" + string x + ")")
        /// Defines a translation, using only the value for the Y-axis
        static member inline translateY(y: int) =
            Interop.mkStyle "transform" ("translateY(" + string y + ")")
        /// Defines a 3D translation, using only the value for the Z-axis
        static member inline translateZ(z: int) =
            Interop.mkStyle "transform" ("translateZ(" + string z + ")")

        /// Defines a 2D scale transformation.
        static member inline scale(x: int, y: int) =
            Interop.mkStyle "transform" (
                "scale(" + string x + "," + string y + ")"
            )
        /// Defines a scale transformation.
        static member inline scale(n: int) =
            Interop.mkStyle "transform" (
                "scale(" + string n + ")"
            )

        /// Defines a scale transformation.
        static member inline scale(n: float) =
            Interop.mkStyle "transform" (
                "scale(" + string n + ")"
            )

        /// Defines a 3D scale transformation
        static member inline scale3D(x: int, y: int, z: int) =
            Interop.mkStyle "transform" (
                "scale3d(" + string x + "," + string y + "," + string z + ")"
            )

        /// Defines a scale transformation by giving a value for the X-axis.
        static member inline scaleX(x: int) =
            Interop.mkStyle "transform" ("scaleX(" + string x + ")")

        /// Defines a scale transformation by giving a value for the Y-axis.
        static member inline scaleY(y: int) =
            Interop.mkStyle "transform" ("scaleY(" + string y + ")")
        /// Defines a 3D translation, using only the value for the Z-axis
        static member inline scaleZ(z: int) =
            Interop.mkStyle "transform" ("scaleZ(" + string z + ")")
        /// Defines a 2D rotation, the angle is specified in the parameter.
        static member inline rotate(deg: int) =
            Interop.mkStyle "transform" ("rotate(" + string deg + "deg)")
        /// Defines a 2D rotation, the angle is specified in the parameter.
        static member inline rotate(deg: float) =
            Interop.mkStyle "transform" ("rotate(" + string deg + "deg)")
        /// Defines a 3D rotation along the X-axis.
        static member inline rotateX(deg: float) =
            Interop.mkStyle "transform" ("rotateX(" + string deg + "deg)")
        /// Defines a 3D rotation along the X-axis.
        static member inline rotateX(deg: int) =
            Interop.mkStyle "transform" ("rotateX(" + string deg + "deg)")
        /// Defines a 3D rotation along the Y-axis
        static member inline rotateY(deg: float) =
            Interop.mkStyle "transform" ("rotateY(" + string deg + "deg)")
        /// Defines a 3D rotation along the Y-axis
        static member inline rotateY(deg: int) =
            Interop.mkStyle "transform" ("rotateY(" + string deg + "deg)")
        /// Defines a 3D rotation along the Z-axis
        static member inline rotateZ(deg: float) =
            Interop.mkStyle "transform" ("rotateZ(" + string deg + "deg)")
        /// Defines a 3D rotation along the Z-axis
        static member inline rotateZ(deg: int) =
            Interop.mkStyle "transform" ("rotateZ(" + string deg + "deg)")
        /// Defines a 2D skew transformation along the X- and the Y-axis.
        static member inline skew(xAngle: int, yAngle: int) =
            Interop.mkStyle "transform" ("skew(" + string xAngle + "deg," + string yAngle + "deg)")
        /// Defines a 2D skew transformation along the X- and the Y-axis.
        static member inline skew(xAngle: float, yAngle: float) =
            Interop.mkStyle "transform" ("skew(" + string xAngle + "deg," + string yAngle + "deg)")
        /// Defines a 2D skew transformation along the X-axis
        static member inline skewX(xAngle: int) =
            Interop.mkStyle "transform" ("skewX(" + string xAngle + "deg)")
        /// Defines a 2D skew transformation along the X-axis
        static member inline skewX(xAngle: float) =
            Interop.mkStyle "transform" ("skewX(" + string xAngle + "deg)")
        /// Defines a 2D skew transformation along the Y-axis
        static member inline skewY(xAngle: int) =
            Interop.mkStyle "transform" ("skewY(" + string xAngle + "deg)")
        /// Defines a 2D skew transformation along the Y-axis
        static member inline skewY(xAngle: float) =
            Interop.mkStyle "transform" ("skewY(" + string xAngle + "deg)")
        /// Defines a perspective view for a 3D transformed element
        static member inline perspective(n: int) =
            Interop.mkStyle "transform" ("perspective(" + string n + ")")
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "transform" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "transform" "inherit"

    [<Erase>]
    type margin =
        static member inline auto = Interop.mkStyle "margin" "auto"

    [<Erase>]
    /// The direction property specifies the text direction/writing direction within a block-level element.
    type direction =
        /// Text direction goes from right-to-left
        static member inline rightToLeft = Interop.mkStyle "direction" "rtl"
        /// Text direction goes from left-to-right. This is default
        static member inline leftToRight = Interop.mkStyle "direction" "ltr"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "direction" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "direction" "inherit"

    [<Erase>]
    /// Sets whether or not to display borders on empty cells in a table.
    type emptyCells =
        /// Display borders on empty cells. This is default
        static member show = Interop.mkStyle "empty-cells" "show"
        /// Hide borders on empty cells
        static member hide = Interop.mkStyle "empty-cells" "hide"
        /// Sets this property to its default value
        static member initial = Interop.mkStyle "empty-cells" "initial"
        /// Inherits this property from its parent element
        static member inheritFromParent = Interop.mkStyle "empty-cells" "inherit"


    [<Erase>]
    /// Sets whether or not the animation should play in reverse on alternate cycles.
    type animationDirection =
        /// Default value. The animation should be played as normal
        static member inline normal = Interop.mkStyle "animation-direction" "normal"
        /// The animation should play in reverse direction
        static member inline reverse = Interop.mkStyle "animation-direction" "reverse"
        /// The animation will be played as normal every odd time (1, 3, 5, etc..) and in reverse direction every even time (2, 4, 6, etc...).
        static member inline alternate = Interop.mkStyle "animation-direction" "alternate"
        /// The animation will be played in reverse direction every odd time (1, 3, 5, etc..) and in a normal direction every even time (2,4,6,etc...)
        static member inline alternateReverse = Interop.mkStyle "animation-direction" "alternate-reverse"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "animation-direction" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "animation-direction" "inherit"

    [<Erase>]
    type animationPlayState =
        /// Default value. Specifies that the animation is running.
        static member inline running = Interop.mkStyle "animation-play-state" "running"
        /// Specifies that the animation is paused
        static member inline paused = Interop.mkStyle "animation-play-state" "paused"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "animation-play-state" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "animation-play-state" "inherit"

    [<Erase>]
    type animationIterationCount =
        /// Specifies that the animation should be played infinite times (forever)
        static member inline infinite = Interop.mkStyle "animation-iteration-count" "infinite"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "animation-iteration-count" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "animation-iteration-count" "inherit"

    [<Erase>]
    /// Specifies a style for the element when the animation is not playing (before it starts, after it ends, or both).
    type animationFillMode =
        /// Default value. Animation will not apply any styles to the element before or after it is executing
        static member inline none = Interop.mkStyle "animation-fill-mode" "none"
        /// The element will retain the style values that is set by the last keyframe (depends on animation-direction and animation-iteration-count).
        static member inline forwards = Interop.mkStyle "animation-fill-mode" "forwards"
        /// The element will get the style values that is set by the first keyframe (depends on animation-direction), and retain this during the animation-delay period
        static member inline backwards = Interop.mkStyle "animation-fill-mode" "backwards"
        /// The animation will follow the rules for both forwards and backwards, extending the animation properties in both directions
        static member inline both = Interop.mkStyle "animation-fill-mode" "both"
        /// Sets this property to its default value
        static member inline initial = Interop.mkStyle "animation-fill-mode" "initial"
        /// Inherits this property from its parent element
        static member inline inheritFromParent = Interop.mkStyle "animation-fill-mode" "inherit"

    [<Erase>]
    type backgroundRepeat =
        /// The background image is repeated both vertically and horizontally. This is default.
        static member inline repeat = Interop.mkStyle "background-repeat" "repeat"
        /// The background image is only repeated horizontally.
        static member inline repeatX = Interop.mkStyle "background-repeat" "repeat-x"
        /// The background image is only repeated vertically.
        static member inline repeatY = Interop.mkStyle "background-repeat" "repeat-y"
        /// The background-image is not repeated.
        static member inline noRepeat = Interop.mkStyle "background-repeat" "no-repeat"
        /// Sets this property to its default value.
        static member inline initial = Interop.mkStyle "background-repeat" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "background-repeat" "inherit"

    [<Erase>]
    type position =
        /// Default value. Elements render in order, as they appear in the document flow.
        static member inline defaultStatic = Interop.mkStyle "position" "static"
        /// The element is positioned relative to its first positioned (not static) ancestor element.
        static member inline absolute = Interop.mkStyle "position" "absolute"
        /// The element is positioned relative to the browser window
        static member inline fixedRelativeToWindow = Interop.mkStyle "position" "fixed"
        /// The element is positioned relative to its normal position, so "left:20px" adds 20 pixels to the element's LEFT position.
        static member inline relative = Interop.mkStyle "position" "relative"
        /// The element is positioned based on the user's scroll position
        ///
        /// A sticky element toggles between relative and fixed, depending on the scroll position. It is positioned relative until a given offset position is met in the viewport - then it "sticks" in place (like position:fixed).
        ///
        /// Note: Not supported in IE/Edge 15 or earlier. Supported in Safari from version 6.1 with a -webkit- prefix.
        static member inline sticky = Interop.mkStyle "position" "sticky"
        static member inline initial = Interop.mkStyle "position" "initial"
        /// Inherits this property from its parent element.
        static member inline inheritFromParent = Interop.mkStyle "position" "inherit"

    [<Erase; RequireQualifiedAccess>]
    type backgroundColor =
        static member inline  indianRed = Interop.mkStyle "background-color" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "background-color" "#F08080"
        static member inline  salmon = Interop.mkStyle "background-color" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "background-color" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "background-color" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "background-color" "#DC143C"
        static member inline  red = Interop.mkStyle "background-color" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "background-color" "#B22222"
        static member inline  darkred = Interop.mkStyle "background-color" "#8B0000"
        static member inline  pink = Interop.mkStyle "background-color" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "background-color" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "background-color" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "background-color" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "background-color" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "background-color" "#DB7093"
        static member inline  coral = Interop.mkStyle "background-color" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "background-color" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "background-color" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "background-color" "#FF8C00"
        static member inline  orange = Interop.mkStyle "background-color" "#FFA500"
        static member inline  gold = Interop.mkStyle "background-color" "#FFD700"
        static member inline  yellow = Interop.mkStyle "background-color" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "background-color" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "background-color" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "background-color" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "background-color" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "background-color" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "background-color" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "background-color" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "background-color" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "background-color" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "background-color" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "background-color" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "background-color" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "background-color" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "background-color" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "background-color" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "background-color" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "background-color" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "background-color" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "background-color" "#663399"
        static member inline  blueViolet = Interop.mkStyle "background-color" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "background-color" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "background-color" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "background-color" "#8B008B"
        static member inline  purple = Interop.mkStyle "background-color" "#800080"
        static member inline  indigo = Interop.mkStyle "background-color" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "background-color" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "background-color" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "background-color" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "background-color" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "background-color" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "background-color" "#7CFC00"
        static member inline  lime = Interop.mkStyle "background-color" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "background-color" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "background-color" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "background-color" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "background-color" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "background-color" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "background-color" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "background-color" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "background-color" "#228B22"
        static member inline  green = Interop.mkStyle "background-color" "#008000"
        static member inline  darkGreen = Interop.mkStyle "background-color" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "background-color" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "background-color" "#6B8E23"
        static member inline  olive = Interop.mkStyle "background-color" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "background-color" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "background-color" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "background-color" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "background-color" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "background-color" "#008B8B"
        static member inline  teal = Interop.mkStyle "background-color" "#008080"
        static member inline  aqua = Interop.mkStyle "background-color" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "background-color" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "background-color" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "background-color" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "background-color" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "background-color" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "background-color" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "background-color" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "background-color" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "background-color" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "background-color" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "background-color" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "background-color" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "background-color" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "background-color" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "background-color" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "background-color" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "background-color" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "background-color" "#4169E1"
        static member inline  blue = Interop.mkStyle "background-color" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "background-color" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "background-color" "#00008B"
        static member inline  navy = Interop.mkStyle "background-color" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "background-color" "#191970"
        static member inline  cornSilk = Interop.mkStyle "background-color" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "background-color" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "background-color" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "background-color" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "background-color" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "background-color" "#DEB887"
        static member inline  tan = Interop.mkStyle "background-color" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "background-color" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "background-color" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "background-color" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "background-color" "#B8860B"
        static member inline  peru = Interop.mkStyle "background-color" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "background-color" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "background-color" "#8B4513"
        static member inline  sienna = Interop.mkStyle "background-color" "#A0522D"
        static member inline  brown = Interop.mkStyle "background-color" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "background-color" "#A52A2A"
        static member inline  white = Interop.mkStyle "background-color" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "background-color" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "background-color" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "background-color" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "background-color" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "background-color" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "background-color" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "background-color" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "background-color" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "background-color" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "background-color" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "background-color" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "background-color" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "background-color" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "background-color" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "background-color" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "background-color" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "background-color" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "background-color" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "background-color" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "background-color" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "background-color" "#808080"
        static member inline  dimGray = Interop.mkStyle "background-color" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "background-color" "#778899"
        static member inline  slateGray = Interop.mkStyle "background-color" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "background-color" "#2F4F4F"
        static member inline  black = Interop.mkStyle "background-color" "#000000"
        static member inline  transparent = Interop.mkStyle "background-color" "transparent"


    [<Erase; RequireQualifiedAccess>]
    type borderColor =
        static member inline  indianRed = Interop.mkStyle "border-color" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "border-color" "#F08080"
        static member inline  salmon = Interop.mkStyle "border-color" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "border-color" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "border-color" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "border-color" "#DC143C"
        static member inline  red = Interop.mkStyle "border-color" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "border-color" "#B22222"
        static member inline  darkred = Interop.mkStyle "border-color" "#8B0000"
        static member inline  pink = Interop.mkStyle "border-color" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "border-color" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "border-color" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "border-color" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "border-color" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "border-color" "#DB7093"
        static member inline  coral = Interop.mkStyle "border-color" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "border-color" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "border-color" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "border-color" "#FF8C00"
        static member inline  orange = Interop.mkStyle "border-color" "#FFA500"
        static member inline  gold = Interop.mkStyle "border-color" "#FFD700"
        static member inline  yellow = Interop.mkStyle "border-color" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "border-color" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "border-color" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "border-color" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "border-color" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "border-color" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "border-color" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "border-color" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "border-color" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "border-color" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "border-color" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "border-color" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "border-color" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "border-color" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "border-color" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "border-color" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "border-color" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "border-color" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "border-color" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "border-color" "#663399"
        static member inline  blueViolet = Interop.mkStyle "border-color" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "border-color" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "border-color" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "border-color" "#8B008B"
        static member inline  purple = Interop.mkStyle "border-color" "#800080"
        static member inline  indigo = Interop.mkStyle "border-color" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "border-color" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "border-color" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "border-color" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "border-color" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "border-color" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "border-color" "#7CFC00"
        static member inline  lime = Interop.mkStyle "border-color" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "border-color" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "border-color" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "border-color" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "border-color" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "border-color" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "border-color" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "border-color" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "border-color" "#228B22"
        static member inline  green = Interop.mkStyle "border-color" "#008000"
        static member inline  darkGreen = Interop.mkStyle "border-color" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "border-color" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "border-color" "#6B8E23"
        static member inline  olive = Interop.mkStyle "border-color" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "border-color" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "border-color" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "border-color" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "border-color" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "border-color" "#008B8B"
        static member inline  teal = Interop.mkStyle "border-color" "#008080"
        static member inline  aqua = Interop.mkStyle "border-color" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "border-color" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "border-color" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "border-color" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "border-color" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "border-color" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "border-color" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "border-color" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "border-color" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "border-color" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "border-color" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "border-color" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "border-color" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "border-color" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "border-color" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "border-color" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "border-color" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "border-color" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "border-color" "#4169E1"
        static member inline  blue = Interop.mkStyle "border-color" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "border-color" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "border-color" "#00008B"
        static member inline  navy = Interop.mkStyle "border-color" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "border-color" "#191970"
        static member inline  cornSilk = Interop.mkStyle "border-color" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "border-color" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "border-color" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "border-color" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "border-color" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "border-color" "#DEB887"
        static member inline  tan = Interop.mkStyle "border-color" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "border-color" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "border-color" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "border-color" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "border-color" "#B8860B"
        static member inline  peru = Interop.mkStyle "border-color" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "border-color" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "border-color" "#8B4513"
        static member inline  sienna = Interop.mkStyle "border-color" "#A0522D"
        static member inline  brown = Interop.mkStyle "border-color" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "border-color" "#A52A2A"
        static member inline  white = Interop.mkStyle "border-color" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "border-color" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "border-color" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "border-color" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "border-color" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "border-color" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "border-color" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "border-color" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "border-color" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "border-color" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "border-color" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "border-color" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "border-color" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "border-color" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "border-color" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "border-color" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "border-color" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "border-color" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "border-color" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "border-color" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "border-color" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "border-color" "#808080"
        static member inline  dimGray = Interop.mkStyle "border-color" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "border-color" "#778899"
        static member inline  slateGray = Interop.mkStyle "border-color" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "border-color" "#2F4F4F"
        static member inline  black = Interop.mkStyle "border-color" "#000000"
        static member inline  transparent = Interop.mkStyle "border-color" "transparent"

    [<Erase; RequireQualifiedAccess>]
    type color =
        static member inline  indianRed = Interop.mkStyle "color" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "color" "#F08080"
        static member inline  salmon = Interop.mkStyle "color" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "color" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "color" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "color" "#DC143C"
        static member inline  red = Interop.mkStyle "color" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "color" "#B22222"
        static member inline  darkred = Interop.mkStyle "color" "#8B0000"
        static member inline  pink = Interop.mkStyle "color" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "color" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "color" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "color" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "color" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "color" "#DB7093"
        static member inline  coral = Interop.mkStyle "color" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "color" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "color" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "color" "#FF8C00"
        static member inline  orange = Interop.mkStyle "color" "#FFA500"
        static member inline  gold = Interop.mkStyle "color" "#FFD700"
        static member inline  yellow = Interop.mkStyle "color" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "color" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "color" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "color" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "color" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "color" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "color" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "color" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "color" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "color" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "color" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "color" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "color" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "color" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "color" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "color" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "color" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "color" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "color" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "color" "#663399"
        static member inline  blueViolet = Interop.mkStyle "color" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "color" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "color" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "color" "#8B008B"
        static member inline  purple = Interop.mkStyle "color" "#800080"
        static member inline  indigo = Interop.mkStyle "color" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "color" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "color" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "color" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "color" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "color" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "color" "#7CFC00"
        static member inline  lime = Interop.mkStyle "color" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "color" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "color" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "color" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "color" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "color" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "color" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "color" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "color" "#228B22"
        static member inline  green = Interop.mkStyle "color" "#008000"
        static member inline  darkGreen = Interop.mkStyle "color" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "color" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "color" "#6B8E23"
        static member inline  olive = Interop.mkStyle "color" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "color" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "color" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "color" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "color" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "color" "#008B8B"
        static member inline  teal = Interop.mkStyle "color" "#008080"
        static member inline  aqua = Interop.mkStyle "color" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "color" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "color" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "color" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "color" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "color" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "color" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "color" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "color" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "color" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "color" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "color" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "color" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "color" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "color" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "color" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "color" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "color" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "color" "#4169E1"
        static member inline  blue = Interop.mkStyle "color" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "color" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "color" "#00008B"
        static member inline  navy = Interop.mkStyle "color" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "color" "#191970"
        static member inline  cornSilk = Interop.mkStyle "color" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "color" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "color" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "color" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "color" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "color" "#DEB887"
        static member inline  tan = Interop.mkStyle "color" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "color" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "color" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "color" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "color" "#B8860B"
        static member inline  peru = Interop.mkStyle "color" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "color" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "color" "#8B4513"
        static member inline  sienna = Interop.mkStyle "color" "#A0522D"
        static member inline  brown = Interop.mkStyle "color" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "color" "#A52A2A"
        static member inline  white = Interop.mkStyle "color" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "color" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "color" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "color" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "color" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "color" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "color" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "color" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "color" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "color" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "color" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "color" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "color" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "color" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "color" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "color" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "color" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "color" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "color" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "color" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "color" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "color" "#808080"
        static member inline  dimGray = Interop.mkStyle "color" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "color" "#778899"
        static member inline  slateGray = Interop.mkStyle "color" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "color" "#2F4F4F"
        static member inline  black = Interop.mkStyle "color" "#000000"
        static member inline  transparent = Interop.mkStyle "color" "transparent"

    [<Erase; RequireQualifiedAccess>]
    type textDecorationColor =
        static member inline  indianRed = Interop.mkStyle "text-decoration-color" "#CD5C5C"
        static member inline  lightCoral = Interop.mkStyle "text-decoration-color" "#F08080"
        static member inline  salmon = Interop.mkStyle "text-decoration-color" "#FA8072"
        static member inline  darkSalmon = Interop.mkStyle "text-decoration-color" "#E9967A"
        static member inline  lightSalmon = Interop.mkStyle "text-decoration-color" "#FFA07A"
        static member inline  crimson = Interop.mkStyle "text-decoration-color" "#DC143C"
        static member inline  red = Interop.mkStyle "text-decoration-color" "#FF0000"
        static member inline  fireBrick = Interop.mkStyle "text-decoration-color" "#B22222"
        static member inline  darkred = Interop.mkStyle "text-decoration-color" "#8B0000"
        static member inline  pink = Interop.mkStyle "text-decoration-color" "#FFC0CB"
        static member inline  lightPink = Interop.mkStyle "text-decoration-color" "#FFB6C1"
        static member inline  hotPink = Interop.mkStyle "text-decoration-color" "#FF69B4"
        static member inline  deepPink = Interop.mkStyle "text-decoration-color" "#FF1493"
        static member inline  mediumVioletRed = Interop.mkStyle "text-decoration-color" "#C71585"
        static member inline  paleVioletRed = Interop.mkStyle "text-decoration-color" "#DB7093"
        static member inline  coral = Interop.mkStyle "text-decoration-color" "#FF7F50"
        static member inline  tomato = Interop.mkStyle "text-decoration-color" "#FF6347"
        static member inline  orangeRed = Interop.mkStyle "text-decoration-color" "#FF4500"
        static member inline  darkOrange = Interop.mkStyle "text-decoration-color" "#FF8C00"
        static member inline  orange = Interop.mkStyle "text-decoration-color" "#FFA500"
        static member inline  gold = Interop.mkStyle "text-decoration-color" "#FFD700"
        static member inline  yellow = Interop.mkStyle "text-decoration-color" "#FFFF00"
        static member inline  lightYellow = Interop.mkStyle "text-decoration-color" "#FFFFE0"
        static member inline  limonChiffon = Interop.mkStyle "text-decoration-color" "#FFFACD"
        static member inline  lightGoldenRodYellow = Interop.mkStyle "text-decoration-color" "#FAFAD2"
        static member inline  papayaWhip = Interop.mkStyle "text-decoration-color" "#FFEFD5"
        static member inline  moccasin = Interop.mkStyle "text-decoration-color" "#FFE4B5"
        static member inline  peachPuff = Interop.mkStyle "text-decoration-color" "#FFDAB9"
        static member inline  paleGoldenRod = Interop.mkStyle "text-decoration-color" "#EEE8AA"
        static member inline  khaki = Interop.mkStyle "text-decoration-color" "#F0E68C"
        static member inline  darkKhaki = Interop.mkStyle "text-decoration-color" "#BDB76B"
        static member inline  lavender = Interop.mkStyle "text-decoration-color" "#E6E6FA"
        static member inline  thistle = Interop.mkStyle "text-decoration-color" "#D8BFD8"
        static member inline  plum = Interop.mkStyle "text-decoration-color" "#DDA0DD"
        static member inline  violet = Interop.mkStyle "text-decoration-color" "#EE82EE"
        static member inline  orchid = Interop.mkStyle "text-decoration-color" "#DA70D6"
        static member inline  fuchsia = Interop.mkStyle "text-decoration-color" "#FF00FF"
        static member inline  magenta = Interop.mkStyle "text-decoration-color" "#FF00FF"
        static member inline  mediumOrchid = Interop.mkStyle "text-decoration-color" "#BA55D3"
        static member inline  mediumPurple = Interop.mkStyle "text-decoration-color" "#9370DB"
        static member inline  rebeccaPurple = Interop.mkStyle "text-decoration-color" "#663399"
        static member inline  blueViolet = Interop.mkStyle "text-decoration-color" "#8A2BE2"
        static member inline  darkViolet = Interop.mkStyle "text-decoration-color" "#9400D3"
        static member inline  darkOrchid = Interop.mkStyle "text-decoration-color" "#9932CC"
        static member inline  darkMagenta = Interop.mkStyle "text-decoration-color" "#8B008B"
        static member inline  purple = Interop.mkStyle "text-decoration-color" "#800080"
        static member inline  indigo = Interop.mkStyle "text-decoration-color" "#4B0082"
        static member inline  slateBlue = Interop.mkStyle "text-decoration-color" "#6A5ACD"
        static member inline  darkSlateBlue = Interop.mkStyle "text-decoration-color" "#483D8B"
        static member inline  mediumSlateBlue = Interop.mkStyle "text-decoration-color" "#7B68EE"
        static member inline  greenYellow = Interop.mkStyle "text-decoration-color" "#ADFF2F"
        static member inline  chartreuse = Interop.mkStyle "text-decoration-color" "#7FFF00"
        static member inline  lawnGreen = Interop.mkStyle "text-decoration-color" "#7CFC00"
        static member inline  lime = Interop.mkStyle "text-decoration-color" "#00FF00"
        static member inline  limeGreen = Interop.mkStyle "text-decoration-color" "#32CD32"
        static member inline  paleGreen = Interop.mkStyle "text-decoration-color" "#98FB98"
        static member inline  lightGreen = Interop.mkStyle "text-decoration-color" "#90EE90"
        static member inline  mediumSpringGreen = Interop.mkStyle "text-decoration-color" "#00FA9A"
        static member inline  springGreen = Interop.mkStyle "text-decoration-color" "#00FF7F"
        static member inline  mediumSeaGreen = Interop.mkStyle "text-decoration-color" "#3CB371"
        static member inline  seaGreen = Interop.mkStyle "text-decoration-color" "#2E8B57"
        static member inline  forestGreen = Interop.mkStyle "text-decoration-color" "#228B22"
        static member inline  green = Interop.mkStyle "text-decoration-color" "#008000"
        static member inline  darkGreen = Interop.mkStyle "text-decoration-color" "#006400"
        static member inline  yellowGreen = Interop.mkStyle "text-decoration-color" "#9ACD32"
        static member inline  oliveDrab = Interop.mkStyle "text-decoration-color" "#6B8E23"
        static member inline  olive = Interop.mkStyle "text-decoration-color" "#808000"
        static member inline  darkOliveGreen = Interop.mkStyle "text-decoration-color" "#556B2F"
        static member inline  mediumAquamarine = Interop.mkStyle "text-decoration-color" "#66CDAA"
        static member inline  darkSeaGreen = Interop.mkStyle "text-decoration-color" "#8FBC8B"
        static member inline  lightSeaGreen = Interop.mkStyle "text-decoration-color" "#20B2AA"
        static member inline  darkCyan = Interop.mkStyle "text-decoration-color" "#008B8B"
        static member inline  teal = Interop.mkStyle "text-decoration-color" "#008080"
        static member inline  aqua = Interop.mkStyle "text-decoration-color" "#00FFFF"
        static member inline  cyan = Interop.mkStyle "text-decoration-color" "#00FFFF"
        static member inline  lightCyan = Interop.mkStyle "text-decoration-color" "#E0FFFF"
        static member inline  paleTurqouise = Interop.mkStyle "text-decoration-color" "#AFEEEE"
        static member inline  aquaMarine = Interop.mkStyle "text-decoration-color" "#7FFFD4"
        static member inline  turqouise = Interop.mkStyle "text-decoration-color" "#AFEEEE"
        static member inline  mediumTurqouise = Interop.mkStyle "text-decoration-color" "#48D1CC"
        static member inline  darkTurqouise = Interop.mkStyle "text-decoration-color" "#00CED1"
        static member inline  cadetBlue = Interop.mkStyle "text-decoration-color" "#5F9EA0"
        static member inline  steelBlue = Interop.mkStyle "text-decoration-color" "#4682B4"
        static member inline  lightSteelBlue = Interop.mkStyle "text-decoration-color" "#B0C4DE"
        static member inline  powederBlue = Interop.mkStyle "text-decoration-color" "#B0E0E6"
        static member inline  lightBlue = Interop.mkStyle "text-decoration-color" "#ADD8E6"
        static member inline  skyBlue = Interop.mkStyle "text-decoration-color" "#87CEEB"
        static member inline  lightSkyBlue = Interop.mkStyle "text-decoration-color" "#87CEFA"
        static member inline  deepSkyBlue = Interop.mkStyle "text-decoration-color" "#00BFFF"
        static member inline  dodgerBlue = Interop.mkStyle "text-decoration-color" "#1E90FF"
        static member inline  cornFlowerBlue = Interop.mkStyle "text-decoration-color" "#6495ED"
        static member inline  royalBlue = Interop.mkStyle "text-decoration-color" "#4169E1"
        static member inline  blue = Interop.mkStyle "text-decoration-color" "#0000FF"
        static member inline  mediumBlue = Interop.mkStyle "text-decoration-color" "#0000CD"
        static member inline  darkBlue = Interop.mkStyle "text-decoration-color" "#00008B"
        static member inline  navy = Interop.mkStyle "text-decoration-color" "#000080"
        static member inline  midnightBlue = Interop.mkStyle "text-decoration-color" "#191970"
        static member inline  cornSilk = Interop.mkStyle "text-decoration-color" "#FFF8DC"
        static member inline  blanchedAlmond = Interop.mkStyle "text-decoration-color" "#FFEBCD"
        static member inline  bisque = Interop.mkStyle "text-decoration-color" "#FFE4C4"
        static member inline  navajoWhite = Interop.mkStyle "text-decoration-color" "#FFDEAD"
        static member inline  wheat = Interop.mkStyle "text-decoration-color" "#F5DEB3"
        static member inline  burlyWood = Interop.mkStyle "text-decoration-color" "#DEB887"
        static member inline  tan = Interop.mkStyle "text-decoration-color" "#D2B48C"
        static member inline  rosyBrown = Interop.mkStyle "text-decoration-color" "#BC8F8F"
        static member inline  sandyBrown = Interop.mkStyle "text-decoration-color" "#F4A460"
        static member inline  goldenRod = Interop.mkStyle "text-decoration-color" "#DAA520"
        static member inline  darkGoldenRod = Interop.mkStyle "text-decoration-color" "#B8860B"
        static member inline  peru = Interop.mkStyle "text-decoration-color" "#CD853F"
        static member inline  chocolate = Interop.mkStyle "text-decoration-color" "#D2691E"
        static member inline  saddleBrown = Interop.mkStyle "text-decoration-color" "#8B4513"
        static member inline  sienna = Interop.mkStyle "text-decoration-color" "#A0522D"
        static member inline  brown = Interop.mkStyle "text-decoration-color" "#A52A2A"
        static member inline  maroon = Interop.mkStyle "text-decoration-color" "#A52A2A"
        static member inline  white = Interop.mkStyle "text-decoration-color" "#FFFFFF"
        static member inline  snow = Interop.mkStyle "text-decoration-color" "#FFFAFA"
        static member inline  honeyDew = Interop.mkStyle "text-decoration-color" "#F0FFF0"
        static member inline  mintCream = Interop.mkStyle "text-decoration-color" "#F5FFFA"
        static member inline  azure = Interop.mkStyle "text-decoration-color" "#F0FFFF"
        static member inline  aliceBlue = Interop.mkStyle "text-decoration-color" "#F0F8FF"
        static member inline  ghostWhite = Interop.mkStyle "text-decoration-color" "#F8F8FF"
        static member inline  whiteSmoke = Interop.mkStyle "text-decoration-color" "#F5F5F5"
        static member inline  seaShell = Interop.mkStyle "text-decoration-color" "#FFF5EE"
        static member inline  beige = Interop.mkStyle "text-decoration-color" "#F5F5DC"
        static member inline  oldLace = Interop.mkStyle "text-decoration-color" "#FDF5E6"
        static member inline  floralWhite = Interop.mkStyle "text-decoration-color" "#FFFAF0"
        static member inline  ivory = Interop.mkStyle "text-decoration-color" "#FFFFF0"
        static member inline  antiqueWhite = Interop.mkStyle "text-decoration-color" "#FAEBD7"
        static member inline  linen = Interop.mkStyle "text-decoration-color" "#FAF0E6"
        static member inline  lavenderBlush = Interop.mkStyle "text-decoration-color" "#FFF0F5"
        static member inline  mistyRose = Interop.mkStyle "text-decoration-color" "#FFE4E1"
        static member inline  gainsBoro = Interop.mkStyle "text-decoration-color" "#DCDCDC"
        static member inline  lightGray = Interop.mkStyle "text-decoration-color" "#D3D3D3"
        static member inline  silver = Interop.mkStyle "text-decoration-color" "#C0C0C0"
        static member inline  darkGray = Interop.mkStyle "text-decoration-color" "#A9A9A9"
        static member inline  gray = Interop.mkStyle "text-decoration-color" "#808080"
        static member inline  dimGray = Interop.mkStyle "text-decoration-color" "#696969"
        static member inline  lightSlateGray = Interop.mkStyle "text-decoration-color" "#778899"
        static member inline  slateGray = Interop.mkStyle "text-decoration-color" "#708090"
        static member inline  darkSlateGray = Interop.mkStyle "text-decoration-color" "#2F4F4F"
        static member inline  black = Interop.mkStyle "text-decoration-color" "#000000"
        static member inline  transparent = Interop.mkStyle "text-decoration-color" "transparent"
