﻿using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace Color.Comment
{
	internal static class Definitions
	{
		#pragma warning disable 169
		#pragma warning disable IDE0051

		// > The field is never used
		// Reason: The field is used by MEF.

		#region Default

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Default")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Default;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Default.Slashes")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Default_Slashes;

		#region ParamRef

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.ParamRef.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_ParamRef_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.ParamRef.Param")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_ParamRef_Param;

		#endregion
		#region TParamRef

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.TParamRef.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_TParamRef_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.TParamRef.TParam")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_TParamRef_TParam;

		#endregion
		#region MemberRef

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.MemberRef.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_MemberRef_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.MemberRef.Member")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_MemberRef_Member;

		#endregion
		#region StaticRef

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.StaticRef.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_StaticRef_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.StaticRef.Static")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_StaticRef_Static;

		#endregion
		#region LocalRef

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.LocalRef.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_LocalRef_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.LocalRef.Local")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_LocalRef_Local;

		#endregion
		#region MacroRef

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.MacroRef.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_MacroRef_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.MacroRef.Macro")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_MacroRef_Macro;

		#endregion
		#region Quote

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Quote.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Quote_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Quote.Text")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Quote_Text;

		#endregion
		#region Code

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Code.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Code_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Code.Text")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Code_Text;

		#endregion
		#region InlineCode

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.InlineCode.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_InlineCode_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.InlineCode.Text")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_InlineCode_Text;

		#endregion
		#endregion
		#region Triple

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Slashes")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Slashes;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Punct")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Punct;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Punct.Header")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Punct_Header;

		#region Triple.Effect

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Effect.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Effect_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Effect.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Effect_Desc;

		#endregion
		#region Triple.Note

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Note.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Note_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Note.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Note_Desc;

		#endregion
		#region Triple.Todo

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Todo.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Todo_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Todo.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Todo_Desc;

		#endregion
		#region Triple.See

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.See.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_See_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.See.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_See_Desc;

		#endregion
		#region Triple.Bug

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Bug.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Bug_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Bug.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Bug_Desc;

		#endregion
		#region Triple.Return

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Return.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Return_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Return.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Return_Desc;

		#endregion
		#region Triple.Spare

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Spare.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Spare_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Spare.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Spare_Desc;

		#endregion
		#region Triple.Throw

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Throw.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Throw_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Throw.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Throw_Desc;

		#endregion
		#region Triple.Param

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Param.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Param_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Param.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Param_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.Param.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_Param_Desc;

		#endregion
		#region Triple.TParam

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.TParam.Mark")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_TParam_Mark;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.TParam.Name")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_TParam_Name;

		[Export(typeof(ClassificationTypeDefinition))]
		[Name("Comment.Triple.TParam.Desc")]
		private static readonly ClassificationTypeDefinition
		Definition_Comment_Triple_TParam_Desc;

		#endregion
		#endregion

		#pragma warning restore IDE0051
		#pragma warning restore 169
	}
}