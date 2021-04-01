using System.Collections.Generic;
using System.Xml.Serialization;

namespace FireburstGenerator
{
	[XmlRoot(ElementName = "platform")]
	public class Platform
	{
		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }

		[XmlAttribute(AttributeName = "protect")]
		public string Protect { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "platforms")]
	public class Platforms
	{
		[XmlElement(ElementName = "platform")] public List<Platform> Platform { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "tag")]
	public class Tag
	{
		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }

		[XmlAttribute(AttributeName = "author")]
		public string Author { get; set; }

		[XmlAttribute(AttributeName = "contact")]
		public string Contact { get; set; }
	}

	[XmlRoot(ElementName = "tags")]
	public class Tags
	{
		[XmlElement(ElementName = "tag")] public List<Tag> Tag { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "type")]
	public class Type
	{
		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }
		[XmlElement(ElementName = "name")] public string? ElementName { get; set; }

		[XmlAttribute(AttributeName = "category")]
		public string Category { get; set; }

		[XmlText] public string Text { get; set; }

		[XmlAttribute(AttributeName = "requires")]
		public string Requires { get; set; }

		[XmlElement(ElementName = "type")] public List<string> Types { get; set; }

		[XmlAttribute(AttributeName = "alias")]
		public string? Alias { get; set; }

		[XmlAttribute(AttributeName = "bitvalues")]
		public string Bitvalues { get; set; }

		[XmlAttribute(AttributeName = "objtypeenum")]
		public string Objtypeenum { get; set; }

		[XmlAttribute(AttributeName = "parent")]
		public string Parent { get; set; }

		[XmlElement(ElementName = "member")] public List<Member> Member { get; set; }

		[XmlAttribute(AttributeName = "returnedonly")]
		public string Returnedonly { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string _Comment { get; set; }

		[XmlElement(ElementName = "comment")] public List<string> Comment { get; set; }

		[XmlAttribute(AttributeName = "structextends")]
		public string Structextends { get; set; }

		[XmlAttribute(AttributeName = "allowduplicate")]
		public string Allowduplicate { get; set; }
	}

	[XmlRoot(ElementName = "member")]
	public class Member
	{
		[XmlElement(ElementName = "type")] public string Type { get; set; }
		[XmlElement(ElementName = "name")] public string Name { get; set; }

		[XmlAttribute(AttributeName = "optional")]
		public string Optional { get; set; }

		[XmlAttribute(AttributeName = "noautovalidity")]
		public string Noautovalidity { get; set; }

		[XmlElement(ElementName = "enum")] public string? Enum { get; set; }
		[XmlElement(ElementName = "comment")] public string Comment { get; set; }

		[XmlAttribute(AttributeName = "values")]
		public string Values { get; set; }

		[XmlAttribute(AttributeName = "len")] public string Len { get; set; }

		[XmlAttribute(AttributeName = "altlen")]
		public string Altlen { get; set; }

		[XmlAttribute(AttributeName = "externsync")]
		public string Externsync { get; set; }

		[XmlAttribute(AttributeName = "selection")]
		public string Selection { get; set; }

		[XmlAttribute(AttributeName = "selector")]
		public string Selector { get; set; }

		[XmlText] public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "types")]
	public class Types
	{
		[XmlElement(ElementName = "type")] public List<Type> Type { get; set; }

		[XmlElement(ElementName = "comment")] public List<string> Comment { get; set; }
	}

	[XmlRoot(ElementName = "enum")]
	public class EnumMember
	{
		[XmlAttribute(AttributeName = "value")]
		public string? Value { get; set; }

		[XmlAttribute(AttributeName = "name")] public string? Name { get; set; }

		[XmlAttribute(AttributeName = "alias")]
		public string? Alias { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string? Comment { get; set; }

		[XmlAttribute(AttributeName = "bitpos")]
		public string? Bitpos { get; set; }

		[XmlAttribute(AttributeName = "extends")]
		public string? Extends { get; set; }

		[XmlAttribute(AttributeName = "extnumber")]
		public string? Extnumber { get; set; }

		[XmlAttribute(AttributeName = "offset")]
		public string? Offset { get; set; }

		[XmlAttribute(AttributeName = "dir")] public string? Dir { get; set; }

		[XmlAttribute(AttributeName = "protect")]
		public string? Protect { get; set; }
	}

	[XmlRoot(ElementName = "enums")]
	public class Enum
	{
		[XmlElement(ElementName = "enum")] public List<EnumMember> Members { get; set; }

		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }

		// [XmlElement(ElementName = "comment")] public List<string> Comment { get; set; }
		[XmlAttribute(AttributeName = "type")] public string Type { get; set; }
		// [XmlElement(ElementName = "unused")] public Unused Unused { get; set; }

		[XmlAttribute(AttributeName = "bitwidth")]
		public int Bitwidth { get; set; }
	}

	// [XmlRoot(ElementName = "unused")]
	// public class Unused
	// {
	// 	[XmlAttribute(AttributeName = "start")]
	// 	public string Start { get; set; }
	//
	// 	[XmlAttribute(AttributeName = "comment")]
	// 	public string Comment { get; set; }
	// }

	[XmlRoot(ElementName = "proto")]
	public class Proto
	{
		[XmlElement(ElementName = "type")] public string Type { get; set; }
		[XmlElement(ElementName = "name")] public string Name { get; set; }
	}

	[XmlRoot(ElementName = "param")]
	public class Param
	{
		[XmlElement(ElementName = "type")] public string Type { get; set; }
		[XmlElement(ElementName = "name")] public string Name { get; set; }

		[XmlAttribute(AttributeName = "optional")]
		public string? Optional { get; set; }

		[XmlAttribute(AttributeName = "externsync")]
		public string Externsync { get; set; }

		[XmlAttribute(AttributeName = "len")] public string Len { get; set; }

		[XmlAttribute(AttributeName = "noautovalidity")]
		public string Noautovalidity { get; set; }
		
		[XmlText]
		public string? Text { get; set; }
	}

	[XmlRoot(ElementName = "command")]
	public class Command
	{
		[XmlElement(ElementName = "proto")] public Proto Proto { get; set; }
		[XmlElement(ElementName = "param")] public List<Param> Param { get; set; }

		[XmlAttribute(AttributeName = "successcodes")]
		public string Successcodes { get; set; }

		[XmlAttribute(AttributeName = "errorcodes")]
		public string Errorcodes { get; set; }

		[XmlElement(ElementName = "implicitexternsyncparams")]
		public Implicitexternsyncparams Implicitexternsyncparams { get; set; }

		[XmlAttribute(AttributeName = "queues")]
		public string Queues { get; set; }

		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }

		[XmlAttribute(AttributeName = "alias")]
		public string? Alias { get; set; }

		[XmlAttribute(AttributeName = "renderpass")]
		public string Renderpass { get; set; }

		[XmlAttribute(AttributeName = "cmdbufferlevel")]
		public string Cmdbufferlevel { get; set; }

		[XmlAttribute(AttributeName = "pipeline")]
		public string Pipeline { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "implicitexternsyncparams")]
	public class Implicitexternsyncparams
	{
		[XmlElement(ElementName = "param")] public string Param { get; set; }
	}

	[XmlRoot(ElementName = "commands")]
	public class Commands
	{
		[XmlElement(ElementName = "command")] public List<Command> Command { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "require")]
	public class Require
	{
		[XmlElement(ElementName = "type")] public List<Type> Type { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string _Comment { get; set; }

		[XmlElement(ElementName = "comment")] public List<string> Comment { get; set; }
		[XmlElement(ElementName = "enum")] public List<EnumMember> Enum { get; set; }
		[XmlElement(ElementName = "command")] public List<Command> Command { get; set; }

		[XmlAttribute(AttributeName = "feature")]
		public string Feature { get; set; }

		[XmlAttribute(AttributeName = "extension")]
		public string Extension { get; set; }
	}

	[XmlRoot(ElementName = "feature")]
	public class Feature
	{
		[XmlElement(ElementName = "require")] public List<Require> Require { get; set; }
		[XmlAttribute(AttributeName = "api")] public string Api { get; set; }
		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }

		[XmlAttribute(AttributeName = "number")]
		public string Number { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "extension")]
	public class Extension
	{
		[XmlElement(ElementName = "require")] public List<Require> Require { get; set; }
		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }

		[XmlAttribute(AttributeName = "number")]
		public string Number { get; set; }

		[XmlAttribute(AttributeName = "type")] public string Type { get; set; }

		[XmlAttribute(AttributeName = "author")]
		public string Author { get; set; }

		[XmlAttribute(AttributeName = "contact")]
		public string Contact { get; set; }

		[XmlAttribute(AttributeName = "supported")]
		public string Supported { get; set; }

		[XmlAttribute(AttributeName = "requires")]
		public string Requires { get; set; }

		[XmlAttribute(AttributeName = "platform")]
		public string Platform { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }

		[XmlAttribute(AttributeName = "specialuse")]
		public string Specialuse { get; set; }

		[XmlAttribute(AttributeName = "deprecatedby")]
		public string Deprecatedby { get; set; }

		[XmlAttribute(AttributeName = "promotedto")]
		public string Promotedto { get; set; }

		[XmlAttribute(AttributeName = "obsoletedby")]
		public string Obsoletedby { get; set; }

		[XmlAttribute(AttributeName = "requiresCore")]
		public string RequiresCore { get; set; }

		[XmlAttribute(AttributeName = "sortorder")]
		public string Sortorder { get; set; }

		[XmlAttribute(AttributeName = "provisional")]
		public string Provisional { get; set; }
	}

	[XmlRoot(ElementName = "extensions")]
	public class Extensions
	{
		[XmlElement(ElementName = "extension")]
		public List<Extension> Extension { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "enable")]
	public class Enable
	{
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }

		[XmlAttribute(AttributeName = "extension")]
		public string Extension { get; set; }

		[XmlAttribute(AttributeName = "struct")]
		public string Struct { get; set; }

		[XmlAttribute(AttributeName = "feature")]
		public string Feature { get; set; }

		[XmlAttribute(AttributeName = "requires")]
		public string Requires { get; set; }

		[XmlAttribute(AttributeName = "property")]
		public string Property { get; set; }

		[XmlAttribute(AttributeName = "member")]
		public string Member { get; set; }

		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }

		[XmlAttribute(AttributeName = "alias")]
		public string Alias { get; set; }
	}

	[XmlRoot(ElementName = "spirvextension")]
	public class Spirvextension
	{
		[XmlElement(ElementName = "enable")] public List<Enable> Enable { get; set; }
		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }
	}

	[XmlRoot(ElementName = "spirvextensions")]
	public class Spirvextensions
	{
		[XmlElement(ElementName = "spirvextension")]
		public List<Spirvextension> Spirvextension { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "spirvcapability")]
	public class Spirvcapability
	{
		[XmlElement(ElementName = "enable")] public List<Enable> Enable { get; set; }
		[XmlAttribute(AttributeName = "name")] public string Name { get; set; }
	}

	[XmlRoot(ElementName = "spirvcapabilities")]
	public class Spirvcapabilities
	{
		[XmlElement(ElementName = "spirvcapability")]
		public List<Spirvcapability> Spirvcapability { get; set; }

		[XmlAttribute(AttributeName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "registry")]
	public class Registry
	{
		[XmlElement(ElementName = "comment")] public List<string> Comment { get; set; }

		[XmlElement(ElementName = "platforms")]
		public Platforms Platforms { get; set; }

		[XmlElement(ElementName = "tags")] public Tags Tags { get; set; }
		[XmlElement(ElementName = "types")] public Types Types { get; set; }
		[XmlElement(ElementName = "enums")] public List<Enum> Enums { get; set; }
		[XmlElement(ElementName = "commands")] public Commands Commands { get; set; }
		[XmlElement(ElementName = "feature")] public List<Feature> Feature { get; set; }

		[XmlElement(ElementName = "extensions")]
		public Extensions Extensions { get; set; }

		[XmlElement(ElementName = "spirvextensions")]
		public Spirvextensions Spirvextensions { get; set; }

		[XmlElement(ElementName = "spirvcapabilities")]
		public Spirvcapabilities Spirvcapabilities { get; set; }
	}
}