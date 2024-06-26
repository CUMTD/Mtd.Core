using System.Diagnostics.CodeAnalysis;

namespace Mtd.Core.Entities
{
	public abstract class GuidEntity : Entity, IIdentity<string>
	{
		private const string GUID_FORMAT = "N";
		public required string Id { get; set; }

		[SetsRequiredMembers()]
		protected GuidEntity()
		{
			Id = Guid.NewGuid().ToString(GUID_FORMAT);
		}

		public static string FormatGuid(Guid guid) => guid.ToString(GUID_FORMAT);
	}
}
