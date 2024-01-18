namespace Mtd.Core.Entities
{
	public abstract class GuidEntity : Entity, IIdentity<string>
	{
		private const string GUID_FORMAT = "N";
		public string Id { get; set; }

		protected GuidEntity()
		{
			Id = Guid.NewGuid().ToString(GUID_FORMAT);
		}

		public static string FormatGuid(Guid guid) => guid.ToString(GUID_FORMAT);
	}
}
