using System.Collections.Generic;
using Signals;
using UnityEngine;
using UnityEngine.UIElements;

namespace Fiber.UIElements
{
    // We need specific props for each style in order for implicit operators to work.
    // Implicit operators can't convert more than 1 step.
    public struct PositionProp
    {
        public SignalProp<StyleEnum<Position>> SignalProp { get; }
        public readonly bool IsEmpty => SignalProp.IsEmpty;
        public readonly bool IsValue => SignalProp.IsValue;
        public readonly bool IsSignal => SignalProp.IsSignal;

        public PositionProp(StyleEnum<Position> value)
        {
            SignalProp = value;
        }

        public PositionProp(BaseSignal<StyleEnum<Position>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator PositionProp(StyleKeyword keyword)
        {
            StyleEnum<Position> styleEnum = keyword;
            return new PositionProp(styleEnum);
        }

        public static implicit operator PositionProp(Position position)
        {
            StyleEnum<Position> styleEnum = position;
            return new PositionProp(styleEnum);
        }

        public static implicit operator PositionProp(BaseSignal<StyleEnum<Position>> signal)
        {
            return new PositionProp(signal);
        }

        public readonly StyleEnum<Position> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopPositionProp
    {
        public WorkLoopSignalProp<StyleEnum<Position>> WorkLoopSignalProp { get; }

        public WorkLoopPositionProp(PositionProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<Position>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<Position> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleLengthProp
    {
        public SignalProp<StyleLength> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleLengthProp(StyleLength value)
        {
            SignalProp = value;
        }

        public StyleLengthProp(BaseSignal<StyleLength> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleLengthProp(StyleKeyword keyword)
        {
            StyleLength value = keyword;
            return new StyleLengthProp(value);
        }

        public static implicit operator StyleLengthProp(float v)
        {
            StyleLength value = v;
            return new StyleLengthProp(value);
        }

        public static implicit operator StyleLengthProp(Length v)
        {
            StyleLength value = v;
            return new StyleLengthProp(value);
        }

        public static implicit operator StyleLengthProp(BaseSignal<StyleLength> signal)
        {
            return new StyleLengthProp(signal);
        }

        public StyleLength Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleLengthProp
    {
        public WorkLoopSignalProp<StyleLength> WorkLoopSignalProp { get; }

        public WorkLoopStyleLengthProp(StyleLengthProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleLength>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleLength Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct WorkLoopStyleMaterialDefinitionProp
    {
        public WorkLoopSignalProp<StyleMaterialDefinition> WorkLoopSignalProp { get; }

        public bool IsEmpty => WorkLoopSignalProp.IsEmpty;
        public bool IsValue => WorkLoopSignalProp.IsValue;
        public bool IsSignal => WorkLoopSignalProp.IsSignal;

        public WorkLoopStyleMaterialDefinitionProp(StyleMaterialDefinitionProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleMaterialDefinition>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleMaterialDefinition Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleFloatProp
    {
        public SignalProp<StyleFloat> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleFloatProp(StyleFloat value)
        {
            SignalProp = value;
        }

        public StyleFloatProp(BaseSignal<StyleFloat> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleFloatProp(StyleKeyword keyword)
        {
            StyleFloat value = keyword;
            return new StyleFloatProp(value);
        }

        public static implicit operator StyleFloatProp(float v)
        {
            StyleFloat value = v;
            return new StyleFloatProp(value);
        }

        public static implicit operator StyleFloatProp(BaseSignal<StyleFloat> signal)
        {
            return new StyleFloatProp(signal);
        }

        public StyleFloat Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleFloatProp
    {
        public WorkLoopSignalProp<StyleFloat> WorkLoopSignalProp { get; }

        public WorkLoopStyleFloatProp(StyleFloatProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleFloat>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleFloat Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleColorProp
    {
        public SignalProp<StyleColor> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleColorProp(StyleColor value)
        {
            SignalProp = value;
        }

        public StyleColorProp(BaseSignal<StyleColor> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleColorProp(StyleKeyword keyword)
        {
            StyleColor value = keyword;
            return new StyleColorProp(value);
        }

        public static implicit operator StyleColorProp(Color v)
        {
            StyleColor value = v;
            return new StyleColorProp(value);
        }

        public static implicit operator StyleColorProp(BaseSignal<StyleColor> signal)
        {
            return new StyleColorProp(signal);
        }

        public StyleColor Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleColorProp
    {
        public WorkLoopSignalProp<StyleColor> WorkLoopSignalProp { get; }

        public WorkLoopStyleColorProp(StyleColorProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleColor>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleColor Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct DisplayStyleProp
    {
        public SignalProp<StyleEnum<DisplayStyle>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public DisplayStyleProp(StyleEnum<DisplayStyle> value)
        {
            SignalProp = value;
        }

        public DisplayStyleProp(BaseSignal<StyleEnum<DisplayStyle>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator DisplayStyleProp(StyleKeyword keyword)
        {
            StyleEnum<DisplayStyle> styleEnum = keyword;
            return new DisplayStyleProp(styleEnum);
        }

        public static implicit operator DisplayStyleProp(DisplayStyle displayStyle)
        {
            StyleEnum<DisplayStyle> styleEnum = displayStyle;
            return new DisplayStyleProp(styleEnum);
        }

        public static implicit operator DisplayStyleProp(BaseSignal<StyleEnum<DisplayStyle>> signal)
        {
            return new DisplayStyleProp(signal);
        }

        public StyleEnum<DisplayStyle> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopDisplayStyleProp
    {
        public WorkLoopSignalProp<StyleEnum<DisplayStyle>> WorkLoopSignalProp { get; }

        public WorkLoopDisplayStyleProp(DisplayStyleProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<DisplayStyle>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<DisplayStyle> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct FlexDirectionProp
    {
        public SignalProp<StyleEnum<FlexDirection>> SignalProp { get; }
        public readonly bool IsEmpty => SignalProp.IsEmpty;
        public readonly bool IsValue => SignalProp.IsValue;
        public readonly bool IsSignal => SignalProp.IsSignal;

        public FlexDirectionProp(StyleEnum<FlexDirection> value)
        {
            SignalProp = value;
        }

        public FlexDirectionProp(BaseSignal<StyleEnum<FlexDirection>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator FlexDirectionProp(StyleKeyword keyword)
        {
            StyleEnum<FlexDirection> styleEnum = keyword;
            return new FlexDirectionProp(styleEnum);
        }

        public static implicit operator FlexDirectionProp(FlexDirection flexDirection)
        {
            StyleEnum<FlexDirection> styleEnum = flexDirection;
            return new FlexDirectionProp(styleEnum);
        }

        public static implicit operator FlexDirectionProp(BaseSignal<StyleEnum<FlexDirection>> signal)
        {
            return new FlexDirectionProp(signal);
        }

        public readonly StyleEnum<FlexDirection> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopFlexDirectionProp
    {
        public WorkLoopSignalProp<StyleEnum<FlexDirection>> WorkLoopSignalProp { get; }

        public WorkLoopFlexDirectionProp(FlexDirectionProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<FlexDirection>>(prop.SignalProp);
        }
        public readonly bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public readonly StyleEnum<FlexDirection> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct JustifyProp
    {
        public SignalProp<StyleEnum<Justify>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public JustifyProp(StyleEnum<Justify> value)
        {
            SignalProp = value;
        }

        public JustifyProp(BaseSignal<StyleEnum<Justify>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator JustifyProp(StyleKeyword keyword)
        {
            StyleEnum<Justify> styleEnum = keyword;
            return new JustifyProp(styleEnum);
        }

        public static implicit operator JustifyProp(Justify justify)
        {
            StyleEnum<Justify> styleEnum = justify;
            return new JustifyProp(styleEnum);
        }

        public static implicit operator JustifyProp(BaseSignal<StyleEnum<Justify>> signal)
        {
            return new JustifyProp(signal);
        }

        public StyleEnum<Justify> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopJustifyProp
    {
        public WorkLoopSignalProp<StyleEnum<Justify>> WorkLoopSignalProp { get; }

        public WorkLoopJustifyProp(JustifyProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<Justify>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<Justify> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct AlignProp
    {
        public SignalProp<StyleEnum<Align>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public AlignProp(StyleEnum<Align> value)
        {
            SignalProp = value;
        }

        public AlignProp(BaseSignal<StyleEnum<Align>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator AlignProp(StyleKeyword keyword)
        {
            StyleEnum<Align> styleEnum = keyword;
            return new AlignProp(styleEnum);
        }

        public static implicit operator AlignProp(Align align)
        {
            StyleEnum<Align> styleEnum = align;
            return new AlignProp(styleEnum);
        }

        public static implicit operator AlignProp(BaseSignal<StyleEnum<Align>> signal)
        {
            return new AlignProp(signal);
        }

        public StyleEnum<Align> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopAlignProp
    {
        public WorkLoopSignalProp<StyleEnum<Align>> WorkLoopSignalProp { get; }

        public WorkLoopAlignProp(AlignProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<Align>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<Align> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct WrapProp
    {
        public SignalProp<StyleEnum<Wrap>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public WrapProp(StyleEnum<Wrap> value)
        {
            SignalProp = value;
        }

        public WrapProp(BaseSignal<StyleEnum<Wrap>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator WrapProp(StyleKeyword keyword)
        {
            StyleEnum<Wrap> styleEnum = keyword;
            return new WrapProp(styleEnum);
        }

        public static implicit operator WrapProp(Wrap wrap)
        {
            StyleEnum<Wrap> styleEnum = wrap;
            return new WrapProp(styleEnum);
        }

        public static implicit operator WrapProp(BaseSignal<StyleEnum<Wrap>> signal)
        {
            return new WrapProp(signal);
        }

        public StyleEnum<Wrap> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopWrapProp
    {
        public WorkLoopSignalProp<StyleEnum<Wrap>> WorkLoopSignalProp { get; }

        public WorkLoopWrapProp(WrapProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<Wrap>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<Wrap> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleFontProp
    {
        public SignalProp<StyleFont> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleFontProp(StyleFont value)
        {
            SignalProp = value;
        }

        public StyleFontProp(BaseSignal<StyleFont> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleFontProp(Font value)
        {
            return new StyleFontProp(value);
        }

        public static implicit operator StyleFontProp(StyleFont value)
        {
            return new StyleFontProp(value);
        }

        public static implicit operator StyleFontProp(BaseSignal<StyleFont> signal)
        {
            return new StyleFontProp(signal);
        }

        public StyleFont Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleFontProp
    {
        public WorkLoopSignalProp<StyleFont> WorkLoopSignalProp { get; }

        public WorkLoopStyleFontProp(StyleFontProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleFont>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleFont Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleFontDefinitionProp
    {
        public SignalProp<StyleFontDefinition> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleFontDefinitionProp(StyleFontDefinition value)
        {
            SignalProp = value;
        }

        public StyleFontDefinitionProp(BaseSignal<StyleFontDefinition> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleFontDefinitionProp(StyleFontDefinition value)
        {
            return new StyleFontDefinitionProp(value);
        }

        public static implicit operator StyleFontDefinitionProp(StyleKeyword keyword)
        {
            return new StyleFontDefinitionProp(keyword);
        }

        public static implicit operator StyleFontDefinitionProp(FontDefinition font)
        {
            return new StyleFontDefinitionProp(font);
        }

        public static implicit operator StyleFontDefinitionProp(BaseSignal<StyleFontDefinition> signal)
        {
            return new StyleFontDefinitionProp(signal);
        }

        public StyleFontDefinition Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleFontDefinitionProp
    {
        public WorkLoopSignalProp<StyleFontDefinition> WorkLoopSignalProp { get; }

        public WorkLoopStyleFontDefinitionProp(StyleFontDefinitionProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleFontDefinition>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleFontDefinition Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct FontStyleProp
    {
        public SignalProp<StyleEnum<FontStyle>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public FontStyleProp(StyleEnum<FontStyle> value)
        {
            SignalProp = value;
        }

        public FontStyleProp(BaseSignal<StyleEnum<FontStyle>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator FontStyleProp(FontStyle value)
        {
            return new FontStyleProp(value);
        }

        public static implicit operator FontStyleProp(StyleKeyword keyword)
        {
            return new FontStyleProp(keyword);
        }

        public static implicit operator FontStyleProp(BaseSignal<StyleEnum<FontStyle>> signal)
        {
            return new FontStyleProp(signal);
        }

        public StyleEnum<FontStyle> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopFontStyleProp
    {
        public WorkLoopSignalProp<StyleEnum<FontStyle>> WorkLoopSignalProp { get; }

        public WorkLoopFontStyleProp(FontStyleProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<FontStyle>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<FontStyle> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StylePropertyNamesProp
    {
        public SignalProp<StyleList<StylePropertyName>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StylePropertyNamesProp(StyleList<StylePropertyName> value)
        {
            SignalProp = value;
        }

        public StylePropertyNamesProp(BaseSignal<StyleList<StylePropertyName>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StylePropertyNamesProp(List<StylePropertyName> value)
        {
            return new StylePropertyNamesProp(value);
        }

        public static implicit operator StylePropertyNamesProp(StyleKeyword keyword)
        {
            return new StylePropertyNamesProp(keyword);
        }

        public static implicit operator StylePropertyNamesProp(BaseSignal<StyleList<StylePropertyName>> signal)
        {
            return new StylePropertyNamesProp(signal);
        }

        public StyleList<StylePropertyName> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStylePropertyNamesProp
    {
        public WorkLoopSignalProp<StyleList<StylePropertyName>> WorkLoopSignalProp { get; }

        public WorkLoopStylePropertyNamesProp(StylePropertyNamesProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleList<StylePropertyName>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleList<StylePropertyName> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct TimeValuesProp
    {
        public SignalProp<StyleList<TimeValue>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public TimeValuesProp(StyleList<TimeValue> value)
        {
            SignalProp = value;
        }

        public TimeValuesProp(BaseSignal<StyleList<TimeValue>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator TimeValuesProp(List<TimeValue> value)
        {
            return new TimeValuesProp(value);
        }

        public static implicit operator TimeValuesProp(StyleKeyword keyword)
        {
            return new TimeValuesProp(keyword);
        }

        public static implicit operator TimeValuesProp(BaseSignal<StyleList<TimeValue>> signal)
        {
            return new TimeValuesProp(signal);
        }

        public StyleList<TimeValue> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopTimeValuesProp
    {
        public WorkLoopSignalProp<StyleList<TimeValue>> WorkLoopSignalProp { get; }

        public WorkLoopTimeValuesProp(TimeValuesProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleList<TimeValue>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleList<TimeValue> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct EasingFunctionsProp
    {
        public SignalProp<StyleList<EasingFunction>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public EasingFunctionsProp(StyleList<EasingFunction> value)
        {
            SignalProp = value;
        }

        public EasingFunctionsProp(BaseSignal<StyleList<EasingFunction>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator EasingFunctionsProp(List<EasingFunction> value)
        {
            return new EasingFunctionsProp(value);
        }

        public static implicit operator EasingFunctionsProp(StyleKeyword keyword)
        {
            return new EasingFunctionsProp(keyword);
        }

        public static implicit operator EasingFunctionsProp(BaseSignal<StyleList<EasingFunction>> signal)
        {
            return new EasingFunctionsProp(signal);
        }

        public StyleList<EasingFunction> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopEasingFunctionsProp
    {
        public WorkLoopSignalProp<StyleList<EasingFunction>> WorkLoopSignalProp { get; }

        public WorkLoopEasingFunctionsProp(EasingFunctionsProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleList<EasingFunction>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleList<EasingFunction> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleTransformOriginProp
    {
        public SignalProp<StyleTransformOrigin> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleTransformOriginProp(StyleTransformOrigin value)
        {
            SignalProp = value;
        }

        public StyleTransformOriginProp(BaseSignal<StyleTransformOrigin> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleTransformOriginProp(TransformOrigin value)
        {
            return new StyleTransformOriginProp(value);
        }

        public static implicit operator StyleTransformOriginProp(StyleKeyword keyword)
        {
            return new StyleTransformOriginProp(keyword);
        }

        public static implicit operator StyleTransformOriginProp(BaseSignal<StyleTransformOrigin> signal)
        {
            return new StyleTransformOriginProp(signal);
        }

        public StyleTransformOrigin Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleTransformOriginProp
    {
        public WorkLoopSignalProp<StyleTransformOrigin> WorkLoopSignalProp { get; }

        public WorkLoopStyleTransformOriginProp(StyleTransformOriginProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleTransformOrigin>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleTransformOrigin Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleTranslateProp
    {
        public SignalProp<StyleTranslate> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleTranslateProp(StyleTranslate value)
        {
            SignalProp = value;
        }

        public StyleTranslateProp(BaseSignal<StyleTranslate> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleTranslateProp(Translate value)
        {
            return new StyleTranslateProp(value);
        }

        public static implicit operator StyleTranslateProp(StyleKeyword keyword)
        {
            return new StyleTranslateProp(keyword);
        }

        public static implicit operator StyleTranslateProp(BaseSignal<StyleTranslate> signal)
        {
            return new StyleTranslateProp(signal);
        }

        public StyleTranslate Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleTranslateProp
    {
        public WorkLoopSignalProp<StyleTranslate> WorkLoopSignalProp { get; }

        public WorkLoopStyleTranslateProp(StyleTranslateProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleTranslate>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleTranslate Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleScaleProp
    {
        public SignalProp<StyleScale> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleScaleProp(StyleScale value)
        {
            SignalProp = value;
        }

        public StyleScaleProp(BaseSignal<StyleScale> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleScaleProp(Scale value)
        {
            return new StyleScaleProp(value);
        }

        public static implicit operator StyleScaleProp(StyleKeyword keyword)
        {
            return new StyleScaleProp(keyword);
        }

        public static implicit operator StyleScaleProp(BaseSignal<StyleScale> signal)
        {
            return new StyleScaleProp(signal);
        }

        public StyleScale Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleScaleProp
    {
        public WorkLoopSignalProp<StyleScale> WorkLoopSignalProp { get; }

        public WorkLoopStyleScaleProp(StyleScaleProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleScale>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleScale Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleRotateProp
    {
        public SignalProp<StyleRotate> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleRotateProp(StyleRotate value)
        {
            SignalProp = value;
        }

        public StyleRotateProp(BaseSignal<StyleRotate> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator StyleRotateProp(Rotate value)
        {
            return new StyleRotateProp(value);
        }

        public static implicit operator StyleRotateProp(StyleKeyword keyword)
        {
            return new StyleRotateProp(keyword);
        }

        public static implicit operator StyleRotateProp(BaseSignal<StyleRotate> signal)
        {
            return new StyleRotateProp(signal);
        }

        public StyleRotate Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopStyleRotateProp
    {
        public WorkLoopSignalProp<StyleRotate> WorkLoopSignalProp { get; }

        public WorkLoopStyleRotateProp(StyleRotateProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleRotate>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleRotate Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct TextAnchorProp
    {
        public SignalProp<StyleEnum<TextAnchor>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public TextAnchorProp(StyleEnum<TextAnchor> value)
        {
            SignalProp = value;
        }

        public TextAnchorProp(BaseSignal<StyleEnum<TextAnchor>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator TextAnchorProp(TextAnchor value)
        {
            return new TextAnchorProp(value);
        }

        public static implicit operator TextAnchorProp(StyleKeyword keyword)
        {
            return new TextAnchorProp(keyword);
        }

        public static implicit operator TextAnchorProp(BaseSignal<StyleEnum<TextAnchor>> signal)
        {
            return new TextAnchorProp(signal);
        }

        public StyleEnum<TextAnchor> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopTextAnchorProp
    {
        public WorkLoopSignalProp<StyleEnum<TextAnchor>> WorkLoopSignalProp { get; }

        public WorkLoopTextAnchorProp(TextAnchorProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<TextAnchor>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<TextAnchor> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct OverflowProp
    {
        public SignalProp<StyleEnum<Overflow>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public OverflowProp(StyleEnum<Overflow> value)
        {
            SignalProp = value;
        }

        public OverflowProp(BaseSignal<StyleEnum<Overflow>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator OverflowProp(Overflow value)
        {
            return new OverflowProp(value);
        }

        public static implicit operator OverflowProp(StyleKeyword keyword)
        {
            return new OverflowProp(keyword);
        }

        public static implicit operator OverflowProp(BaseSignal<StyleEnum<Overflow>> signal)
        {
            return new OverflowProp(signal);
        }

        public StyleEnum<Overflow> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopOverflowProp
    {
        public WorkLoopSignalProp<StyleEnum<Overflow>> WorkLoopSignalProp { get; }

        public WorkLoopOverflowProp(OverflowProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<Overflow>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<Overflow> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct TextOverflowProp
    {
        public SignalProp<StyleEnum<TextOverflow>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public TextOverflowProp(StyleEnum<TextOverflow> value)
        {
            SignalProp = value;
        }

        public TextOverflowProp(BaseSignal<StyleEnum<TextOverflow>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator TextOverflowProp(TextOverflow value)
        {
            return new TextOverflowProp(value);
        }

        public static implicit operator TextOverflowProp(StyleKeyword keyword)
        {
            return new TextOverflowProp(keyword);
        }

        public static implicit operator TextOverflowProp(BaseSignal<StyleEnum<TextOverflow>> signal)
        {
            return new TextOverflowProp(signal);
        }

        public StyleEnum<TextOverflow> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopTextOverflowProp
    {
        public WorkLoopSignalProp<StyleEnum<TextOverflow>> WorkLoopSignalProp { get; }

        public WorkLoopTextOverflowProp(TextOverflowProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<TextOverflow>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<TextOverflow> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct WhiteSpaceProp
    {
        public SignalProp<StyleEnum<WhiteSpace>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public WhiteSpaceProp(StyleEnum<WhiteSpace> value)
        {
            SignalProp = value;
        }

        public WhiteSpaceProp(BaseSignal<StyleEnum<WhiteSpace>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator WhiteSpaceProp(WhiteSpace value)
        {
            return new WhiteSpaceProp(value);
        }

        public static implicit operator WhiteSpaceProp(StyleKeyword keyword)
        {
            return new WhiteSpaceProp(keyword);
        }

        public static implicit operator WhiteSpaceProp(BaseSignal<StyleEnum<WhiteSpace>> signal)
        {
            return new WhiteSpaceProp(signal);
        }

        public StyleEnum<WhiteSpace> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopWhiteSpaceProp
    {
        public WorkLoopSignalProp<StyleEnum<WhiteSpace>> WorkLoopSignalProp { get; }

        public WorkLoopWhiteSpaceProp(WhiteSpaceProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<WhiteSpace>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<WhiteSpace> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct StyleMaterialDefinitionProp
    {
        public SignalProp<StyleMaterialDefinition> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public StyleMaterialDefinitionProp(StyleMaterialDefinition value)
        {
            SignalProp = value;
        }

        public StyleMaterialDefinitionProp(BaseSignal<StyleMaterialDefinition> signal)
        {
            SignalProp = signal;
        }


        public static implicit operator StyleMaterialDefinitionProp(StyleKeyword keyword)
        {
            return new StyleMaterialDefinitionProp(keyword);
        }

        public static implicit operator StyleMaterialDefinitionProp(MaterialDefinition m)
        {
            return new StyleMaterialDefinitionProp(new StyleMaterialDefinition(m));
        }

        public static implicit operator StyleMaterialDefinitionProp(Material m)
        {
            return new StyleMaterialDefinitionProp(new StyleMaterialDefinition(m));
        }


        public static implicit operator StyleMaterialDefinitionProp(BaseSignal<StyleMaterialDefinition> signal)
        {
            return new StyleMaterialDefinitionProp(signal);
        }

        public StyleMaterialDefinition Get()
        {
            return SignalProp.Get();
        }
    }

    public struct VisibilityProp
    {
        public SignalProp<StyleEnum<Visibility>> SignalProp { get; }
        public bool IsEmpty => SignalProp.IsEmpty;
        public bool IsValue => SignalProp.IsValue;
        public bool IsSignal => SignalProp.IsSignal;

        public VisibilityProp(StyleEnum<Visibility> value)
        {
            SignalProp = value;
        }

        public VisibilityProp(BaseSignal<StyleEnum<Visibility>> signal)
        {
            SignalProp = signal;
        }

        public static implicit operator VisibilityProp(Visibility value)
        {
            return new VisibilityProp(value);
        }

        public static implicit operator VisibilityProp(StyleKeyword keyword)
        {
            return new VisibilityProp(keyword);
        }

        public static implicit operator VisibilityProp(BaseSignal<StyleEnum<Visibility>> signal)
        {
            return new VisibilityProp(signal);
        }

        public StyleEnum<Visibility> Get()
        {
            return SignalProp.Get();
        }
    }

    public struct WorkLoopVisibilityProp
    {
        public WorkLoopSignalProp<StyleEnum<Visibility>> WorkLoopSignalProp { get; }

        public WorkLoopVisibilityProp(VisibilityProp prop)
        {
            WorkLoopSignalProp = new WorkLoopSignalProp<StyleEnum<Visibility>>(prop.SignalProp);
        }
        public bool Check()
        {
            return WorkLoopSignalProp.Check();
        }
        public StyleEnum<Visibility> Get()
        {
            return WorkLoopSignalProp.Get();
        }
    }

    public struct Style
    {
        public PositionProp Position { get; }
        public StyleLengthProp Right { get; }
        public StyleLengthProp Bottom { get; }
        public StyleLengthProp Left { get; }
        public StyleLengthProp Top { get; }
        public StyleLengthProp PaddingRight { get; }
        public StyleLengthProp PaddingBottom { get; }
        public StyleLengthProp PaddingLeft { get; }
        public StyleLengthProp PaddingTop { get; }
        public StyleLengthProp MarginRight { get; }
        public StyleLengthProp MarginBottom { get; }
        public StyleLengthProp MarginLeft { get; }
        public StyleLengthProp MarginTop { get; }
        public StyleLengthProp BorderTopRightRadius { get; }
        public StyleLengthProp BorderTopLeftRadius { get; }
        public StyleLengthProp BorderBottomRightRadius { get; }
        public StyleLengthProp BorderBottomLeftRadius { get; }
        public StyleFloatProp BorderRightWidth { get; }
        public StyleFloatProp BorderBottomWidth { get; }
        public StyleFloatProp BorderLeftWidth { get; }
        public StyleFloatProp BorderTopWidth { get; }
        public StyleColorProp BorderRightColor { get; }
        public StyleColorProp BorderBottomColor { get; }
        public StyleColorProp BorderLeftColor { get; }
        public StyleColorProp BorderTopColor { get; }
        public DisplayStyleProp Display { get; }
        public StyleFloatProp FlexShrink { get; }
        public StyleFloatProp FlexGrow { get; }
        public FlexDirectionProp FlexDirection { get; }
        public JustifyProp JustifyContent { get; }
        public AlignProp AlignItems { get; }
        public WrapProp FlexWrap { get; }
        public StyleLengthProp Width { get; }
        public StyleLengthProp MaxWidth { get; }
        public StyleLengthProp MinWidth { get; }
        public StyleLengthProp Height { get; }
        public StyleLengthProp MaxHeight { get; }
        public StyleLengthProp MinHeight { get; }
        public StyleColorProp BackgroundColor { get; }
        public StyleColorProp Color { get; }
        public StyleLengthProp FontSize { get; }
        public StyleFontProp UnityFont { get; }
        public StyleFontDefinitionProp UnityFontDefinition { get; }
        public FontStyleProp UnityFontStyle { get; }
        public StyleLengthProp UnityParagraphSpacing { get; }
        public TextAnchorProp UnityTextAlign { get; }
        public StyleFloatProp UnityTextOutlineWidth { get; }
        public StyleColorProp UnityTextOutlineColor { get; }
        public StylePropertyNamesProp TransitionProperty { get; }
        public TimeValuesProp TransitionDelay { get; }
        public TimeValuesProp TransitionDuration { get; }
        public EasingFunctionsProp TransitionTimingFunction { get; }
        public StyleTransformOriginProp TransformOrigin { get; }
        public StyleTranslateProp Translate { get; }
        public StyleScaleProp Scale { get; }
        public StyleRotateProp Rotate { get; }
        public StyleFloatProp Opacity { get; }
        public OverflowProp Overflow { get; }
        public TextOverflowProp TextOverflow { get; }
        public WhiteSpaceProp WhiteSpace { get; }
        public VisibilityProp Visibility { get; }

        public StyleMaterialDefinitionProp UnityMaterial { get; }

        public Style(
            PositionProp position = new(),
            StyleLengthProp right = new(),
            StyleLengthProp bottom = new(),
            StyleLengthProp left = new(),
            StyleLengthProp top = new(),
            StyleLengthProp paddingRight = new(),
            StyleLengthProp paddingBottom = new(),
            StyleLengthProp paddingLeft = new(),
            StyleLengthProp paddingTop = new(),
            StyleLengthProp marginRight = new(),
            StyleLengthProp marginBottom = new(),
            StyleLengthProp marginLeft = new(),
            StyleLengthProp marginTop = new(),
            StyleLengthProp borderTopRightRadius = new(),
            StyleLengthProp borderTopLeftRadius = new(),
            StyleLengthProp borderBottomRightRadius = new(),
            StyleLengthProp borderBottomLeftRadius = new(),
            StyleFloatProp borderRightWidth = new(),
            StyleFloatProp borderBottomWidth = new(),
            StyleFloatProp borderLeftWidth = new(),
            StyleFloatProp borderTopWidth = new(),
            StyleColorProp borderRightColor = new(),
            StyleColorProp borderBottomColor = new(),
            StyleColorProp borderLeftColor = new(),
            StyleColorProp borderTopColor = new(),
            DisplayStyleProp display = new(),
            StyleFloatProp flexShrink = new(),
            StyleFloatProp flexGrow = new(),
            FlexDirectionProp flexDirection = new(),
            JustifyProp justifyContent = new(),
            AlignProp alignItems = new(),
            WrapProp flexWrap = new(),
            StyleLengthProp width = new(),
            StyleLengthProp maxWidth = new(),
            StyleLengthProp minWidth = new(),
            StyleLengthProp height = new(),
            StyleLengthProp maxHeight = new(),
            StyleLengthProp minHeight = new(),
            StyleColorProp backgroundColor = new(),
            StyleColorProp color = new(),
            StyleLengthProp fontSize = new(),
            StyleFontProp unityFont = new(),
            StyleFontDefinitionProp unityFontDefinition = new(),
            FontStyleProp unityFontStyle = new(),
            StyleLengthProp unityParagraphSpacing = new(),
            TextAnchorProp unityTextAlign = new(),
            StyleFloatProp unityTextOutlineWidth = new(),
            StyleColorProp unityTextOutlineColor = new(),
            StylePropertyNamesProp transitionProperty = new(),
            TimeValuesProp transitionDelay = new(),
            TimeValuesProp transitionDuration = new(),
            EasingFunctionsProp transitionTimingFunction = new(),
            StyleTransformOriginProp transformOrigin = new(),
            StyleTranslateProp translate = new(),
            StyleScaleProp scale = new(),
            StyleRotateProp rotate = new(),
            StyleFloatProp opacity = new(),
            OverflowProp overflow = new(),
            TextOverflowProp textOverflow = new(),
            WhiteSpaceProp whiteSpace = new(),
            VisibilityProp visibility = new(),
            StyleMaterialDefinitionProp unityMaterial = new()
        )
        {
            Position = position;
            Right = right;
            Bottom = bottom;
            Left = left;
            Top = top;
            PaddingRight = paddingRight;
            PaddingBottom = paddingBottom;
            PaddingLeft = paddingLeft;
            PaddingTop = paddingTop;
            MarginRight = marginRight;
            MarginBottom = marginBottom;
            MarginLeft = marginLeft;
            MarginTop = marginTop;
            BorderTopRightRadius = borderTopRightRadius;
            BorderTopLeftRadius = borderTopLeftRadius;
            BorderBottomRightRadius = borderBottomRightRadius;
            BorderBottomLeftRadius = borderBottomLeftRadius;
            BorderTopWidth = borderTopWidth;
            BorderRightWidth = borderRightWidth;
            BorderLeftWidth = borderLeftWidth;
            BorderBottomWidth = borderBottomWidth;
            BorderTopColor = borderTopColor;
            BorderRightColor = borderRightColor;
            BorderLeftColor = borderLeftColor;
            BorderBottomColor = borderBottomColor;
            Display = display;
            FlexShrink = flexShrink;
            FlexGrow = flexGrow;
            FlexDirection = flexDirection;
            JustifyContent = justifyContent;
            AlignItems = alignItems;
            FlexWrap = flexWrap;
            Width = width;
            MaxWidth = maxWidth;
            MinWidth = minWidth;
            Height = height;
            MaxHeight = maxHeight;
            MinHeight = minHeight;
            BackgroundColor = backgroundColor;
            Color = color;
            FontSize = fontSize;
            UnityFont = unityFont;
            UnityFontDefinition = unityFontDefinition;
            UnityFontStyle = unityFontStyle;
            UnityParagraphSpacing = unityParagraphSpacing;
            UnityTextAlign = unityTextAlign;
            UnityTextOutlineWidth = unityTextOutlineWidth;
            UnityTextOutlineColor = unityTextOutlineColor;
            TransitionProperty = transitionProperty;
            TransitionDelay = transitionDelay;
            TransitionDuration = transitionDuration;
            TransitionTimingFunction = transitionTimingFunction;
            TransformOrigin = transformOrigin;
            Translate = translate;
            Scale = scale;
            Rotate = rotate;
            Opacity = opacity;
            Overflow = overflow;
            TextOverflow = textOverflow;
            WhiteSpace = whiteSpace;
            Visibility = visibility;
            UnityMaterial = unityMaterial;
        }

        public Style(
            Style mergedStyle,
            PositionProp position = new(),
            StyleLengthProp right = new(),
            StyleLengthProp bottom = new(),
            StyleLengthProp left = new(),
            StyleLengthProp top = new(),
            StyleLengthProp paddingRight = new(),
            StyleLengthProp paddingBottom = new(),
            StyleLengthProp paddingLeft = new(),
            StyleLengthProp paddingTop = new(),
            StyleLengthProp marginRight = new(),
            StyleLengthProp marginBottom = new(),
            StyleLengthProp marginLeft = new(),
            StyleLengthProp marginTop = new(),
            StyleLengthProp borderTopRightRadius = new(),
            StyleLengthProp borderTopLeftRadius = new(),
            StyleLengthProp borderBottomRightRadius = new(),
            StyleLengthProp borderBottomLeftRadius = new(),
            StyleFloatProp borderRightWidth = new(),
            StyleFloatProp borderBottomWidth = new(),
            StyleFloatProp borderLeftWidth = new(),
            StyleFloatProp borderTopWidth = new(),
            StyleColorProp borderRightColor = new(),
            StyleColorProp borderBottomColor = new(),
            StyleColorProp borderLeftColor = new(),
            StyleColorProp borderTopColor = new(),
            DisplayStyleProp display = new(),
            StyleFloatProp flexShrink = new(),
            StyleFloatProp flexGrow = new(),
            FlexDirectionProp flexDirection = new(),
            JustifyProp justifyContent = new(),
            AlignProp alignItems = new(),
            WrapProp flexWrap = new(),
            StyleLengthProp width = new(),
            StyleLengthProp maxWidth = new(),
            StyleLengthProp minWidth = new(),
            StyleLengthProp height = new(),
            StyleLengthProp maxHeight = new(),
            StyleLengthProp minHeight = new(),
            StyleColorProp backgroundColor = new(),
            StyleColorProp color = new(),
            StyleLengthProp fontSize = new(),
            StyleFontProp unityFont = new(),
            StyleFontDefinitionProp unityFontDefinition = new(),
            FontStyleProp unityFontStyle = new(),
            StyleLengthProp unityParagraphSpacing = new(),
            TextAnchorProp unityTextAlign = new(),
            StyleFloatProp unityTextOutlineWidth = new(),
            StyleColorProp unityTextOutlineColor = new(),
            StylePropertyNamesProp transitionProperty = new(),
            TimeValuesProp transitionDelay = new(),
            TimeValuesProp transitionDuration = new(),
            EasingFunctionsProp transitionTimingFunction = new(),
            StyleTransformOriginProp transformOrigin = new(),
            StyleTranslateProp translate = new(),
            StyleScaleProp scale = new(),
            StyleRotateProp rotate = new(),
            StyleFloatProp opacity = new(),
            OverflowProp overflow = new(),
            TextOverflowProp textOverflow = new(),
            WhiteSpaceProp whiteSpace = new(),
            VisibilityProp visibility = new(),
            StyleMaterialDefinitionProp unityMaterial = new()
        )
        {
            Position = mergedStyle.Position.IsEmpty ? position : mergedStyle.Position;
            Right = mergedStyle.Right.IsEmpty ? right : mergedStyle.Right;
            Bottom = mergedStyle.Bottom.IsEmpty ? bottom : mergedStyle.Bottom;
            Left = mergedStyle.Left.IsEmpty ? left : mergedStyle.Left;
            Top = mergedStyle.Top.IsEmpty ? top : mergedStyle.Top;
            PaddingRight = mergedStyle.PaddingRight.IsEmpty ? paddingRight : mergedStyle.PaddingRight;
            PaddingBottom = mergedStyle.PaddingBottom.IsEmpty ? paddingBottom : mergedStyle.PaddingBottom;
            PaddingLeft = mergedStyle.PaddingLeft.IsEmpty ? paddingLeft : mergedStyle.PaddingLeft;
            PaddingTop = mergedStyle.PaddingTop.IsEmpty ? paddingTop : mergedStyle.PaddingTop;
            MarginRight = mergedStyle.MarginRight.IsEmpty ? marginRight : mergedStyle.MarginRight;
            MarginBottom = mergedStyle.MarginBottom.IsEmpty ? marginBottom : mergedStyle.MarginBottom;
            MarginLeft = mergedStyle.MarginLeft.IsEmpty ? marginLeft : mergedStyle.MarginLeft;
            MarginTop = mergedStyle.MarginTop.IsEmpty ? marginTop : mergedStyle.MarginTop;
            BorderTopRightRadius = mergedStyle.BorderTopRightRadius.IsEmpty ? borderTopRightRadius : mergedStyle.BorderTopRightRadius;
            BorderTopLeftRadius = mergedStyle.BorderTopLeftRadius.IsEmpty ? borderTopLeftRadius : mergedStyle.BorderTopLeftRadius;
            BorderBottomRightRadius = mergedStyle.BorderBottomRightRadius.IsEmpty ? borderBottomRightRadius : mergedStyle.BorderBottomRightRadius;
            BorderBottomLeftRadius = mergedStyle.BorderBottomLeftRadius.IsEmpty ? borderBottomLeftRadius : mergedStyle.BorderBottomLeftRadius;
            BorderTopWidth = mergedStyle.BorderTopWidth.IsEmpty ? borderTopWidth : mergedStyle.BorderTopWidth;
            BorderRightWidth = mergedStyle.BorderRightWidth.IsEmpty ? borderRightWidth : mergedStyle.BorderRightWidth;
            BorderLeftWidth = mergedStyle.BorderLeftWidth.IsEmpty ? borderLeftWidth : mergedStyle.BorderLeftWidth;
            BorderBottomWidth = mergedStyle.BorderBottomWidth.IsEmpty ? borderBottomWidth : mergedStyle.BorderBottomWidth;
            BorderTopColor = mergedStyle.BorderTopColor.IsEmpty ? borderTopColor : mergedStyle.BorderTopColor;
            BorderRightColor = mergedStyle.BorderRightColor.IsEmpty ? borderRightColor : mergedStyle.BorderRightColor;
            BorderLeftColor = mergedStyle.BorderLeftColor.IsEmpty ? borderLeftColor : mergedStyle.BorderLeftColor;
            BorderBottomColor = mergedStyle.BorderBottomColor.IsEmpty ? borderBottomColor : mergedStyle.BorderBottomColor;
            Display = mergedStyle.Display.IsEmpty ? display : mergedStyle.Display;
            FlexShrink = mergedStyle.FlexShrink.IsEmpty ? flexShrink : mergedStyle.FlexShrink;
            FlexGrow = mergedStyle.FlexGrow.IsEmpty ? flexGrow : mergedStyle.FlexGrow;
            FlexDirection = mergedStyle.FlexDirection.IsEmpty ? flexDirection : mergedStyle.FlexDirection;
            JustifyContent = mergedStyle.JustifyContent.IsEmpty ? justifyContent : mergedStyle.JustifyContent;
            AlignItems = mergedStyle.AlignItems.IsEmpty ? alignItems : mergedStyle.AlignItems;
            FlexWrap = mergedStyle.FlexWrap.IsEmpty ? flexWrap : mergedStyle.FlexWrap;
            Width = mergedStyle.Width.IsEmpty ? width : mergedStyle.Width;
            MaxWidth = mergedStyle.MaxWidth.IsEmpty ? maxWidth : mergedStyle.MaxWidth;
            MinWidth = mergedStyle.MinWidth.IsEmpty ? minWidth : mergedStyle.MinWidth;
            Height = mergedStyle.Height.IsEmpty ? height : mergedStyle.Height;
            MaxHeight = mergedStyle.MaxHeight.IsEmpty ? maxHeight : mergedStyle.MaxHeight;
            MinHeight = mergedStyle.MinHeight.IsEmpty ? minHeight : mergedStyle.MinHeight;
            BackgroundColor = mergedStyle.BackgroundColor.IsEmpty ? backgroundColor : mergedStyle.BackgroundColor;
            Color = mergedStyle.Color.IsEmpty ? color : mergedStyle.Color;
            FontSize = mergedStyle.FontSize.IsEmpty ? fontSize : mergedStyle.FontSize;
            UnityFont = mergedStyle.UnityFont.IsEmpty ? unityFont : mergedStyle.UnityFont;
            UnityFontDefinition = mergedStyle.UnityFontDefinition.IsEmpty ? unityFontDefinition : mergedStyle.UnityFontDefinition;
            UnityFontStyle = mergedStyle.UnityFontStyle.IsEmpty ? unityFontStyle : mergedStyle.UnityFontStyle;
            UnityParagraphSpacing = mergedStyle.UnityParagraphSpacing.IsEmpty ? unityParagraphSpacing : mergedStyle.UnityParagraphSpacing;
            UnityTextAlign = mergedStyle.UnityTextAlign.IsEmpty ? unityTextAlign : mergedStyle.UnityTextAlign;
            UnityTextOutlineWidth = mergedStyle.UnityTextOutlineWidth.IsEmpty ? unityTextOutlineWidth : mergedStyle.UnityTextOutlineWidth;
            UnityTextOutlineColor = mergedStyle.UnityTextOutlineColor.IsEmpty ? unityTextOutlineColor : mergedStyle.UnityTextOutlineColor;
            TransitionProperty = mergedStyle.TransitionProperty.IsEmpty ? transitionProperty : mergedStyle.TransitionProperty;
            TransitionDelay = mergedStyle.TransitionDelay.IsEmpty ? transitionDelay : mergedStyle.TransitionDelay;
            TransitionDuration = mergedStyle.TransitionDuration.IsEmpty ? transitionDuration : mergedStyle.TransitionDuration;
            TransitionTimingFunction = mergedStyle.TransitionTimingFunction.IsEmpty ? transitionTimingFunction : mergedStyle.TransitionTimingFunction;
            TransformOrigin = mergedStyle.TransformOrigin.IsEmpty ? transformOrigin : mergedStyle.TransformOrigin;
            Translate = mergedStyle.Translate.IsEmpty ? translate : mergedStyle.Translate;
            Scale = mergedStyle.Scale.IsEmpty ? scale : mergedStyle.Scale;
            Rotate = mergedStyle.Rotate.IsEmpty ? rotate : mergedStyle.Rotate;
            Opacity = mergedStyle.Opacity.IsEmpty ? opacity : mergedStyle.Opacity;
            Overflow = mergedStyle.Overflow.IsEmpty ? overflow : mergedStyle.Overflow;
            TextOverflow = mergedStyle.TextOverflow.IsEmpty ? textOverflow : mergedStyle.TextOverflow;
            WhiteSpace = mergedStyle.WhiteSpace.IsEmpty ? whiteSpace : mergedStyle.WhiteSpace;
            Visibility = mergedStyle.Visibility.IsEmpty ? visibility : mergedStyle.Visibility;
            UnityMaterial = mergedStyle.UnityMaterial.IsEmpty ? unityMaterial : mergedStyle.UnityMaterial;
        }
    }
}
