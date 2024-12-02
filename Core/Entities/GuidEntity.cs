using System.ComponentModel.DataAnnotations;

namespace Mtd.Core.Entities
{
	public abstract class GuidEntity() : Entity, IIdentity<string>
	{
		private const string GUID_FORMAT = "N";

		[Key]
		public string Id { get; set; } = Guid.CreateVersion7().ToString(GUID_FORMAT);

		public static string FormatGuid(Guid guid) => guid.ToString(GUID_FORMAT);
	}
}
