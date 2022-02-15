/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XMLParser
{
	[XmlRoot(ElementName = "regulation", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class Regulation
	{
		[XmlElement(ElementName = "publicationUrl", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public string PublicationUrl { get; set; }
		[XmlAttribute(AttributeName = "regulationType")]
		public string RegulationType { get; set; }
		[XmlAttribute(AttributeName = "organisationType")]
		public string OrganisationType { get; set; }
		[XmlAttribute(AttributeName = "publicationDate")]
		public string PublicationDate { get; set; }
		[XmlAttribute(AttributeName = "entryIntoForceDate")]
		public string EntryIntoForceDate { get; set; }
		[XmlAttribute(AttributeName = "numberTitle")]
		public string NumberTitle { get; set; }
		[XmlAttribute(AttributeName = "programme")]
		public string Programme { get; set; }
		[XmlAttribute(AttributeName = "logicalId")]
		public string LogicalId { get; set; }
	}

	[XmlRoot(ElementName = "subjectType", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class SubjectType
	{
		[XmlAttribute(AttributeName = "code")]
		public string Code { get; set; }
		[XmlAttribute(AttributeName = "classificationCode")]
		public string ClassificationCode { get; set; }
	}

	[XmlRoot(ElementName = "regulationSummary", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class RegulationSummary
	{
		[XmlAttribute(AttributeName = "regulationType")]
		public string RegulationType { get; set; }
		[XmlAttribute(AttributeName = "publicationDate")]
		public string PublicationDate { get; set; }
		[XmlAttribute(AttributeName = "numberTitle")]
		public string NumberTitle { get; set; }
		[XmlAttribute(AttributeName = "publicationUrl")]
		public string PublicationUrl { get; set; }
	}

	[XmlRoot(ElementName = "nameAlias", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class NameAlias
	{
		[XmlElement(ElementName = "regulationSummary", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public RegulationSummary RegulationSummary { get; set; }
		[XmlAttribute(AttributeName = "firstName")]
		public string FirstName { get; set; }
		[XmlAttribute(AttributeName = "middleName")]
		public string MiddleName { get; set; }
		[XmlAttribute(AttributeName = "lastName")]
		public string LastName { get; set; }
		[XmlAttribute(AttributeName = "wholeName")]
		public string WholeName { get; set; }
		[XmlAttribute(AttributeName = "function")]
		public string Function { get; set; }
		[XmlAttribute(AttributeName = "gender")]
		public string Gender { get; set; }
		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName = "nameLanguage")]
		public string NameLanguage { get; set; }
		[XmlAttribute(AttributeName = "strong")]
		public string Strong { get; set; }
		[XmlAttribute(AttributeName = "regulationLanguage")]
		public string RegulationLanguage { get; set; }
		[XmlAttribute(AttributeName = "logicalId")]
		public string LogicalId { get; set; }
		[XmlElement(ElementName = "remark", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public string Remark { get; set; }
	}

	[XmlRoot(ElementName = "citizenship", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class Citizenship
	{
		[XmlElement(ElementName = "regulationSummary", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public RegulationSummary RegulationSummary { get; set; }
		[XmlAttribute(AttributeName = "region")]
		public string Region { get; set; }
		[XmlAttribute(AttributeName = "countryIso2Code")]
		public string CountryIso2Code { get; set; }
		[XmlAttribute(AttributeName = "countryDescription")]
		public string CountryDescription { get; set; }
		[XmlAttribute(AttributeName = "regulationLanguage")]
		public string RegulationLanguage { get; set; }
		[XmlAttribute(AttributeName = "logicalId")]
		public string LogicalId { get; set; }
		[XmlElement(ElementName = "remark", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public string Remark { get; set; }
	}

	[XmlRoot(ElementName = "birthdate", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class Birthdate
	{
		[XmlElement(ElementName = "regulationSummary", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public RegulationSummary RegulationSummary { get; set; }
		[XmlAttribute(AttributeName = "circa")]
		public string Circa { get; set; }
		[XmlAttribute(AttributeName = "calendarType")]
		public string CalendarType { get; set; }
		[XmlAttribute(AttributeName = "city")]
		public string City { get; set; }
		[XmlAttribute(AttributeName = "zipCode")]
		public string ZipCode { get; set; }
		[XmlAttribute(AttributeName = "birthdate")]
		public string _birthdate { get; set; }
		[XmlAttribute(AttributeName = "dayOfMonth")]
		public string DayOfMonth { get; set; }
		[XmlAttribute(AttributeName = "monthOfYear")]
		public string MonthOfYear { get; set; }
		[XmlAttribute(AttributeName = "year")]
		public string Year { get; set; }
		[XmlAttribute(AttributeName = "region")]
		public string Region { get; set; }
		[XmlAttribute(AttributeName = "place")]
		public string Place { get; set; }
		[XmlAttribute(AttributeName = "countryIso2Code")]
		public string CountryIso2Code { get; set; }
		[XmlAttribute(AttributeName = "countryDescription")]
		public string CountryDescription { get; set; }
		[XmlAttribute(AttributeName = "regulationLanguage")]
		public string RegulationLanguage { get; set; }
		[XmlAttribute(AttributeName = "logicalId")]
		public string LogicalId { get; set; }
		[XmlElement(ElementName = "remark", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<string> Remark { get; set; }
		[XmlAttribute(AttributeName = "yearRangeFrom")]
		public string YearRangeFrom { get; set; }
		[XmlAttribute(AttributeName = "yearRangeTo")]
		public string YearRangeTo { get; set; }
	}

	[XmlRoot(ElementName = "sanctionEntity", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class SanctionEntity
	{
		[XmlElement(ElementName = "remark", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public string Remark { get; set; }
		[XmlElement(ElementName = "regulation", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public Regulation Regulation { get; set; }
		[XmlElement(ElementName = "subjectType", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public SubjectType SubjectType { get; set; }
		[XmlElement(ElementName = "nameAlias", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<NameAlias> NameAlias { get; set; }
		[XmlElement(ElementName = "citizenship", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<Citizenship> Citizenship { get; set; }
		[XmlElement(ElementName = "birthdate", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<Birthdate> Birthdate { get; set; }
		[XmlAttribute(AttributeName = "designationDetails")]
		public string DesignationDetails { get; set; }
		[XmlAttribute(AttributeName = "unitedNationId")]
		public string UnitedNationId { get; set; }
		[XmlAttribute(AttributeName = "euReferenceNumber")]
		public string EuReferenceNumber { get; set; }
		[XmlAttribute(AttributeName = "logicalId")]
		public string LogicalId { get; set; }
		[XmlElement(ElementName = "identification", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<Identification> Identification { get; set; }
		[XmlElement(ElementName = "address", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<Address> Address { get; set; }
		[XmlAttribute(AttributeName = "designationDate")]
		public string DesignationDate { get; set; }
	}

	[XmlRoot(ElementName = "identification", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class Identification
	{
		[XmlElement(ElementName = "remark", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<string> Remark { get; set; }
		[XmlElement(ElementName = "regulationSummary", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public RegulationSummary RegulationSummary { get; set; }
		[XmlAttribute(AttributeName = "diplomatic")]
		public string Diplomatic { get; set; }
		[XmlAttribute(AttributeName = "knownExpired")]
		public string KnownExpired { get; set; }
		[XmlAttribute(AttributeName = "knownFalse")]
		public string KnownFalse { get; set; }
		[XmlAttribute(AttributeName = "reportedLost")]
		public string ReportedLost { get; set; }
		[XmlAttribute(AttributeName = "revokedByIssuer")]
		public string RevokedByIssuer { get; set; }
		[XmlAttribute(AttributeName = "issuedBy")]
		public string IssuedBy { get; set; }
		[XmlAttribute(AttributeName = "latinNumber")]
		public string LatinNumber { get; set; }
		[XmlAttribute(AttributeName = "nameOnDocument")]
		public string NameOnDocument { get; set; }
		[XmlAttribute(AttributeName = "number")]
		public string Number { get; set; }
		[XmlAttribute(AttributeName = "region")]
		public string Region { get; set; }
		[XmlAttribute(AttributeName = "identificationTypeCode")]
		public string IdentificationTypeCode { get; set; }
		[XmlAttribute(AttributeName = "identificationTypeDescription")]
		public string IdentificationTypeDescription { get; set; }
		[XmlAttribute(AttributeName = "countryIso2Code")]
		public string CountryIso2Code { get; set; }
		[XmlAttribute(AttributeName = "countryDescription")]
		public string CountryDescription { get; set; }
		[XmlAttribute(AttributeName = "regulationLanguage")]
		public string RegulationLanguage { get; set; }
		[XmlAttribute(AttributeName = "logicalId")]
		public string LogicalId { get; set; }
		[XmlAttribute(AttributeName = "validTo")]
		public string ValidTo { get; set; }
		[XmlAttribute(AttributeName = "validFrom")]
		public string ValidFrom { get; set; }
		[XmlAttribute(AttributeName = "issueDate")]
		public string IssueDate { get; set; }
	}

	[XmlRoot(ElementName = "address", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class Address
	{
		[XmlElement(ElementName = "regulationSummary", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public RegulationSummary RegulationSummary { get; set; }
		[XmlAttribute(AttributeName = "city")]
		public string City { get; set; }
		[XmlAttribute(AttributeName = "street")]
		public string Street { get; set; }
		[XmlAttribute(AttributeName = "poBox")]
		public string PoBox { get; set; }
		[XmlAttribute(AttributeName = "zipCode")]
		public string ZipCode { get; set; }
		[XmlAttribute(AttributeName = "region")]
		public string Region { get; set; }
		[XmlAttribute(AttributeName = "place")]
		public string Place { get; set; }
		[XmlAttribute(AttributeName = "asAtListingTime")]
		public string AsAtListingTime { get; set; }
		[XmlAttribute(AttributeName = "countryIso2Code")]
		public string CountryIso2Code { get; set; }
		[XmlAttribute(AttributeName = "countryDescription")]
		public string CountryDescription { get; set; }
		[XmlAttribute(AttributeName = "regulationLanguage")]
		public string RegulationLanguage { get; set; }
		[XmlAttribute(AttributeName = "logicalId")]
		public string LogicalId { get; set; }
		[XmlElement(ElementName = "contactInfo", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<ContactInfo> ContactInfo { get; set; }
		[XmlElement(ElementName = "remark", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<string> Remark { get; set; }
	}

	[XmlRoot(ElementName = "contactInfo", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class ContactInfo
	{
		[XmlAttribute(AttributeName = "key")]
		public string Key { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "export", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
	public class Export
	{
		[XmlElement(ElementName = "sanctionEntity", Namespace = "http://eu.europa.ec/fpi/fsd/export")]
		public List<SanctionEntity> SanctionEntity { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "generationDate")]
		public string GenerationDate { get; set; }
		[XmlAttribute(AttributeName = "globalFileId")]
		public string GlobalFileId { get; set; }
	}

}
