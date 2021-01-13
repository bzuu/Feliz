namespace Feliz

open Fable.Core
open Feliz.Styles

[<Erase>]
type horizontalGesture =
    /// Enable single-finger horizontal panning gestures.
    static member inline panX : IHorizontalGesture = unbox "pan-x"
    /// Enable single-finger gestures that begin by scrolling left.
    static member inline panLeft : IHorizontalGesture = unbox "pan-left"
    /// Enable single-finger gestures that begin by scrolling right.
    static member inline panRight : IHorizontalGesture = unbox "pan-right"

[<Erase>]
type verticalGesture =
    /// Enable single-finger vertical panning gestures.
    static member inline panY : IVerticalGesture = unbox "pan-y"
    /// Enable single-finger gestures that begin by scrolling up.
    static member inline panUp : IVerticalGesture = unbox "pan-up"
    /// Enable single-finger gestures that begin by scrolling down.
    static member inline panDown : IVerticalGesture = unbox "pan-down"

[<Erase>]
type multiFingerGesture =
    /// Enable multi-finger panning and zooming of the page.
    static member inline pinchZoom : IMultiFingerGesture = unbox "pinch-zoom"