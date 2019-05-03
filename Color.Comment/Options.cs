using System;
using System.ComponentModel;
using System.Globalization;
using Microsoft.VisualStudio.Shell;

namespace Color.Comment
{
	public enum Option_ReferenceType
	{
		No     = 0,
		Triple = 2,
		All    = 3,
	};

	#region EnumConverter

	public class Option_ReferenceType_Converter
		: EnumConverter
	{
		public Option_ReferenceType_Converter()
			: base(typeof(Option_ReferenceType))
		{}

		public override bool CanConvertFrom(
			ITypeDescriptorContext Context,
			Type Type
		){
			if (Type == typeof(string)) return true;
			return base.CanConvertFrom(Context, Type);
		}

		public override object ConvertFrom(
			ITypeDescriptorContext Context,
			CultureInfo Culture,
			object Value
		){
			if (Value is string String)
			{
				if (String == "No")
				return Option_ReferenceType.No;

				if (String == "Yes, but in triple slash comments only")
				return Option_ReferenceType.Triple;

				if (String == "Yes, in all comments")
				return Option_ReferenceType.All;
			}

			return base.ConvertFrom(Context, Culture, Value);
		}

		public override object ConvertTo(
			ITypeDescriptorContext Context,
			CultureInfo Culture,
			object Value,
			Type DestinationType
		){
			if (DestinationType == typeof(string))
			{
				if ((int) Value == (int) Option_ReferenceType.No)
				return "No";

				if ((int) Value == (int) Option_ReferenceType.Triple)
				return "Yes, but in triple slash comments only";

				if ((int) Value == (int) Option_ReferenceType.All)
				return "Yes, in all comments";
			}

			return base.ConvertTo(Context, Culture, Value, DestinationType);
		}
	}

	#endregion

	public sealed class OptionsPage
		: DialogPage
	{
		[Category("Color.Comment")]
		[DisplayName("​​​​​Color parameter references")]
		[Description("Color parameter references in comments (prefixed by `$`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorParamRef { get; set; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​​​​Color template parameter references")]
		[Description("Color template parameter references in comments (prefixed by `^`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorTParamRef { get; set; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​​​Color member references")]
		[Description("Color non static member references in comments (prefixed by `.`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorMember { get; set; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​​Color static references")]
		[Description("Color static references in comments (prefixed by `!`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorStatic { get; set; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("​Color local references")]
		[Description("Color local references in comments (prefixed by `@`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorLocal { get; set; } = Option_ReferenceType.All;

		[Category("Color.Comment")]
		[DisplayName("Color macro references")]
		[Description("Color macro references in comments (prefixed by `%`).")]
		[TypeConverter(typeof(Option_ReferenceType_Converter))]
		public Option_ReferenceType ColorMacro { get; set; } = Option_ReferenceType.All;
	}

	internal static class Options
	{
		internal static Option_ReferenceType ColorParamRef
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return Option_ReferenceType.No;

				var Page = (OptionsPage) Package.GetDialogPage(typeof(OptionsPage));
				if (Page == null) return Option_ReferenceType.No;

				return Page.ColorParamRef;
			}
		}

		internal static Option_ReferenceType ColorTParamRef
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return Option_ReferenceType.No;

				var Page = (OptionsPage) Package.GetDialogPage(typeof(OptionsPage));
				if (Page == null) return Option_ReferenceType.No;

				return Page.ColorTParamRef;
			}
		}

		internal static Option_ReferenceType ColorMember
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return Option_ReferenceType.No;

				var Page = (OptionsPage) Package.GetDialogPage(typeof(OptionsPage));
				if (Page == null) return Option_ReferenceType.No;

				return Page.ColorMember;
			}
		}

		internal static Option_ReferenceType ColorStatic
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return Option_ReferenceType.No;

				var Page = (OptionsPage) Package.GetDialogPage(typeof(OptionsPage));
				if (Page == null) return Option_ReferenceType.No;

				return Page.ColorStatic;
			}
		}

		internal static Option_ReferenceType ColorLocal
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return Option_ReferenceType.No;

				var Page = (OptionsPage) Package.GetDialogPage(typeof(OptionsPage));
				if (Page == null) return Option_ReferenceType.No;

				return Page.ColorLocal;
			}
		}

		internal static Option_ReferenceType ColorMacro
		{
			get
			{
				var Package = Project.Package;
				if (Package == null) return Option_ReferenceType.No;

				var Page = (OptionsPage) Package.GetDialogPage(typeof(OptionsPage));
				if (Page == null) return Option_ReferenceType.No;

				return Page.ColorMacro;
			}
		}
	}
}