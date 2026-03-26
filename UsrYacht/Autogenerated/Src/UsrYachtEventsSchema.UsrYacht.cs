namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d2097bbf-bd3b-4f36-9738-476fae6b54d0");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a8bd99c9-d0d9-4756-a916-3ab9a7c352bb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,47,244,63,28,126,178,33,136,246,117,221,10,75,72,71,161,108,163,113,6,101,236,65,145,47,142,134,44,25,157,156,46,27,251,239,59,73,73,155,58,29,244,176,177,117,247,233,187,251,62,206,202,14,169,151,10,161,70,239,37,185,117,16,51,103,215,186,29,188,12,218,217,243,179,63,231,103,192,49,144,182,45,44,118,20,176,187,58,78,29,95,236,58,103,255,91,244,40,230,54,232,160,145,222,130,17,243,45,218,112,128,126,79,233,93,202,221,105,30,194,162,47,23,106,131,157,252,204,26,224,3,20,75,242,15,82,109,66,81,253,200,119,250,97,101,180,2,101,36,17,164,210,43,36,240,14,166,146,240,149,74,38,217,203,63,226,115,91,30,88,55,8,91,167,27,248,98,23,114,203,50,74,183,250,137,42,0,161,109,208,79,32,19,78,113,205,154,18,237,71,223,18,96,245,76,119,196,28,99,197,83,136,39,182,3,13,86,87,47,97,153,23,118,81,14,171,46,243,185,202,248,17,182,65,165,59,105,160,247,90,69,139,210,37,241,9,67,189,235,177,153,57,51,116,246,155,52,3,190,223,35,175,203,232,226,215,8,47,198,141,245,26,202,76,116,13,151,23,41,170,151,136,145,160,24,40,110,105,38,173,66,131,13,15,16,252,128,76,123,138,163,224,227,42,240,50,146,108,177,198,174,55,50,196,145,45,62,194,157,83,210,232,223,114,101,112,145,112,101,22,178,36,244,188,172,150,109,231,77,21,247,72,110,240,138,49,206,51,201,4,78,219,196,120,218,147,188,95,197,4,138,147,6,36,146,45,183,84,59,55,213,109,62,21,149,168,221,126,128,234,13,42,120,250,156,16,55,206,119,50,148,35,117,220,248,18,216,197,244,206,151,247,39,142,199,8,27,239,30,147,11,243,95,10,251,40,244,192,51,134,255,125,62,238,127,249,195,207,63,159,205,243,48,228,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c8cc6562-111e-dbab-0aa4-b70a701fe9ed"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("a8bd99c9-d0d9-4756-a916-3ab9a7c352bb"),
				CreatedInSchemaUId = new Guid("d2097bbf-bd3b-4f36-9738-476fae6b54d0"),
				ModifiedInSchemaUId = new Guid("d2097bbf-bd3b-4f36-9738-476fae6b54d0")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2097bbf-bd3b-4f36-9738-476fae6b54d0"));
		}

		#endregion

	}

	#endregion

}

